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
        public static void SubmitRecord(RecordModel record)
        {
            string query = "INSERT INTO Record (StaffID, PatientID, RoomID, ReasonForVisit) VALUES(@StaffID, @PatientID, @RoomID, @ReasonForVisit)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StaffID", record.StaffID);
            command.Parameters.AddWithValue("@PatientID", record.PatientID);
            command.Parameters.AddWithValue("@RoomID", record.RoomID);
            command.Parameters.AddWithValue("@ReasonForVisit", record.ReasonForVisit);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                connection.Close();
            }
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
        public static void AddX()
        {

        }
        public static void RemoveX()
        {

        }
        public static void UpdateX()
        {

        }
        #endregion
    }
}
