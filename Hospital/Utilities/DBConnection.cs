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

        public static void GetAllFromTable(string table)
        {

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

        #region Matthew's Individual Part
        public static void AddTreatment()
        {
        }
        
        public static void AddRecord()
        {

        }
        #endregion


        #region Callum's Individual Part
        //TODO: Callum
        public static void AddWard(string WardDescription, string Specialty, int BuildingID)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand($"INSERT INTO Ward Values ('{WardDescription}', '{Specialty}', '{BuildingID}') ", connection);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public static void RemoveWard(WardModel ward)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand($"DELETE FROM Ward WHERE WardID = {ward.WardID}", connection);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public static void UpdateWard(WardModel ward)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand($"UPDATE Ward SET WardDescription = {ward.WardDescription}, Specialty = {ward.Specialty}, BuildingID = {ward.BuildingID} WHERE WardID = {ward.WardID}", connection);

            cmd.ExecuteNonQuery();

            connection.Close();
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
