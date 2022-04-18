using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using Hospital.Models;

namespace Hospital.Utilities
{
    static class DBConnection
    {
        public static string ServerURL { get; private set; } = "server=(localdb)\\ProjectsV13;Database=HospitalDB";

        static SqlConnection connection = new SqlConnection(ServerURL);


        public static void SetURL(string URL)
        {
            ServerURL = URL;
            connection = new SqlConnection(ServerURL);
        }

        public static List<ServiceModel> GetConsultantServices()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(
                $"SELECT c.FirstName as CFName, c.LastName as CLName, c.StaffID as CStaffID, " +
                $"j.FirstName, j.LastName, j.StaffID FROM Service " +
                $"JOIN Staff AS j ON j.StaffID = MemberID " +
                $"JOIN Staff AS c ON c.StaffID = LeaderID " +
                $"ORDER BY LeaderID ",
                connection
                );

            SqlDataReader reader = cmd.ExecuteReader();

            List<ServiceModel> services = new List<ServiceModel>();

            while (reader.Read())
            {
                //If consultant isn't in the list...
                if (!services.Exists((model) => { return model.Consultant.staff_id == (int)reader["CStaffID"]; }))
                    services.Add(new ServiceModel
                    {
                        Consultant = new StaffModel
                        {
                            staff_id = (int)reader["CStaffID"],
                            first_name = (string)reader["CFName"],
                            last_name = (string)reader["CLName"]
                        },
                    });

                ServiceModel model = services.First((modelA) => { return modelA.Consultant.staff_id == (int)reader["CStaffID"]; });


                model.Juniors.Add(new StaffModel
                {
                    staff_id = (int)reader["StaffID"],
                    first_name = (string)reader["FirstName"],
                    last_name = (string)reader["LastName"]
                });
            }

            connection.Close();

            return services;
            
        }

        public static List<PiiModel> GetAllFromPii()
        {
            List<PiiModel> people = new List<PiiModel>();

            connection.Open();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM  Pii", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                people.Add(new PiiModel(
                    (string)reader["FirstName"],
                    (string)reader["LastName"],
                    (string)reader["MobileNo"],
                    (string)reader["FirstName"],
                    (DateTime)reader["Dob"]
                ));
            }

            connection.Close();

            return people;
        }
        public static void SubmitRecord(RecordModel record)
        {
            string query = $"INSERT INTO Record VALUES ({ record.StaffID }, { record.PatientID }, { record.RoomID }, '{ record.ReasonForVisit}')";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void RegisterPatient()
        {
            //TODO: Ismael
        }

        public static void ChangeJuniorsService(Dictionary<int, int> consultant_junior_ids)
        {
            connection.Open();

            foreach (KeyValuePair<int, int> service in consultant_junior_ids)
            {
                // do something with entry.Value or entry.Key
                SqlCommand cmd = new SqlCommand($"UPDATE Service SET LeaderID = {service.Value} WHERE MemberID = {service.Key}", connection);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }


        #region Callum's Individual Part
        //TODO: Callum
        public static void AddWard(string WardDescription, string Specialty, int BuildingID)
        {

            // Prepare a proper parameterized query 
            string sql = "INSERT INTO WARD ([WardDescription], [Specialty], [BuildingID]) values(@desc,@spec,@bid)";

            // Create the connection (and be sure to dispose it at the end)
            using (SqlConnection cnn = new SqlConnection(ServerURL))
            {
                try
                {
                    // Open the connection to the database. 
                    // This is the first critical step in the process.
                    // If we cannot reach the db then we have connectivity problems
                    cnn.Open();

                    // Prepare the command to be executed on the db
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = WardDescription;
                        cmd.Parameters.Add("@spec", System.Data.SqlDbType.VarChar).Value = Specialty;
                        cmd.Parameters.Add("@bid", System.Data.SqlDbType.Int).Value = BuildingID;
                        // Let's ask the db to execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            System.Windows.Forms.MessageBox.Show("Creation Successful");
                        else
                            // Well this should never really happen
                            System.Windows.Forms.MessageBox.Show("Creation Fail");

                    }
                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    System.Windows.Forms.MessageBox.Show("ERROR:" + ex.Message);
                }
            }
        }
        public static void RemoveWard(WardModel ward)
        {
            // Prepare a proper parameterized query 
            string sql = "DELETE FROM Ward WHERE WardID = @wardID";

            // Create the connection (and be sure to dispose it at the end)
            using (SqlConnection cnn = new SqlConnection(ServerURL))
            {
                try
                {
                    // Open the connection to the database. 
                    // This is the first critical step in the process.
                    // If we cannot reach the db then we have connectivity problems
                    cnn.Open();

                    // Prepare the command to be executed on the db
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@wardID", System.Data.SqlDbType.Int).Value = ward.WardID;
                        // Let's ask the db to execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            System.Windows.Forms.MessageBox.Show("Delete Successful");
                        else
                            // Well this should never really happen
                            System.Windows.Forms.MessageBox.Show("Delete Fail");

                    }
                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    System.Windows.Forms.MessageBox.Show("ERROR:" + ex.Message);
                }
            }
        }
        public static void UpdateWard(string wardDescription, string wardSpecialty, int buildingID, int wardID)
        {

            // Prepare a proper parameterized query 
            string sql = "UPDATE Ward SET WardDescription = @wardDescription, Specialty = @wardSpecialty, BuildingID = @buildingID WHERE WardID = @wardID";

            // Create the connection (and be sure to dispose it at the end)
            using (SqlConnection cnn = new SqlConnection(ServerURL))
            {
                try
                {
                    // Open the connection to the database. 
                    // This is the first critical step in the process.
                    // If we cannot reach the db then we have connectivity problems
                    cnn.Open();

                    // Prepare the command to be executed on the db
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@wardID", System.Data.SqlDbType.Int).Value = wardID;
                        cmd.Parameters.Add("@wardDescription", System.Data.SqlDbType.VarChar).Value = wardDescription;
                        cmd.Parameters.Add("@wardSpecialty", System.Data.SqlDbType.VarChar).Value = wardSpecialty;
                        cmd.Parameters.Add("@buildingID", System.Data.SqlDbType.Int).Value = buildingID;
                        // Let's ask the db to execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            System.Windows.Forms.MessageBox.Show("Update Successful");
                        else
                            // Well this should never really happen
                            System.Windows.Forms.MessageBox.Show("Update Fail");

                    }
                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    System.Windows.Forms.MessageBox.Show("ERROR:" + ex.Message);
                }
            }
           
            
        }
        public static List<BuildingModel> GetBuildings()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(
                $"SELECT BuildingID as BID, AddressID as AID, BuildingName as BNAME FROM Building ",
                connection
                );

            SqlDataReader reader = cmd.ExecuteReader();

            List<BuildingModel> buildings = new List<BuildingModel>();

            while (reader.Read())
            {
                //If building isn't in the list...
                if (!buildings.Exists((model) => { return model.BuildingID == (int)reader["BID"]; }))
                    buildings.Add(new BuildingModel
                    {
                        
                        BuildingID = (int)reader["BID"],
                        AddressID = (int)reader["AID"],
                        BuildingName = (string)reader["BNAME"]
                       
                    });

                BuildingModel model = buildings.First((modelA) => { return modelA.BuildingID == (int)reader["BID"]; });

                
                
            }
            connection.Close();
            return buildings;
        }
        public static List<WardModel>GetWards()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(
                $"SELECT WardID as WID, WardDescription as WD, Specialty as WS, BuildingID as WBID FROM Ward",
                connection
                );

            SqlDataReader reader = cmd.ExecuteReader();

            List<WardModel> wards = new List<WardModel>();

            while (reader.Read())
            {
                //If ward isn't in the list...
                if (!wards.Exists((model) => { return model.WardID == (int)reader["WID"]; }))
                    wards.Add(new WardModel
                    {

                        WardID = (int)reader["WID"],
                        WardDescription = (string)reader["WD"],
                        Specialty = (string)reader["WS"],
                        BuildingID = (int)reader["WBID"]
                       
                    });

                WardModel model = wards.First((modelA) => { return modelA.WardID == (int)reader["WID"]; });



            }
            connection.Close();
            return wards;
        }
        
        #endregion
    }
}
