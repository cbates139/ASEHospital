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
                $"SELECT c.FirstName, c.LastName, c.StaffID, " +
                $"j.FirstName, j.LastName, j.StaffID FROM Service " +
                $"RIGHT JOIN Staff AS j ON j.StaffID = MemberID " +
                $"RIGHT JOIN Staff AS c ON c.StaffID = LeaderID " +
                $"ORDER BY LeaderID ",
                connection
                );

            SqlDataReader reader = cmd.ExecuteReader();

            List<ServiceModel> services = new List<ServiceModel>();

            while (reader.Read())
            {
                //If consultant isn't in the list...
                if (!services.Exists((model) => { return model.Consultant.staff_id == (int)reader["c.StaffID"]; }))
                    services.Add(new ServiceModel
                    {
                        Consultant = new StaffModel
                        {
                            staff_id = (int)reader["c.StaffID"],
                            first_name = (string)reader["c.FirstName"],
                            last_name = (string)reader["c.LastName"]
                        },
                    });

                ServiceModel model = services.First((modelA) => { return modelA.Consultant.staff_id == (int)reader["c.StaffID"]; });


                model.Juniors.Add(new StaffModel
                {
                    staff_id = (int)reader["j.StaffID"],
                    first_name = (string)reader["j.FirstName"],
                    last_name = (string)reader["j.LastName"]
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
                SqlCommand cmd = new SqlCommand($"UPDATE Service SET LeaderID = {service.Key} WHERE MemberID = {service.Value}", connection);

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
