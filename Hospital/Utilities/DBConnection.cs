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
        public static string ServerURL { get; private set; }

        static SqlConnection connection;


        public static void SetURL(string URL)
        {
            ServerURL = URL;
            connection = new SqlConnection(ServerURL);
        }

        public static List<ServiceModel> GetConsultantServices()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(
                $"SELECT Consultant.first_name, Consultant.last_name, Consultant.staff_id, " +
                $"Junior.first_name, Junior.last_name, Junior.staff_id FROM Service" +
                $"LEFT JOIN DoctorStaff as Junior ON Junior.staff_id == member_id" +
                $"LEFT JOIN DoctorStaff as Consultant ON Consultant.staff_id == leader_id" +
                $"GROUP BY Consultant.staff_id" +
                $"ORDER BY Junior.last_name",
                connection
                );

            SqlDataReader reader = cmd.ExecuteReader();

            List<ServiceModel> services = new List<ServiceModel>();

            while (reader.Read())
            {
                //If consultant isn't in the list...
                if (!services.Exists((model) => { return model.Consultant.staff_id == (int)reader["Consultant.staff_id"]; }))
                    services.Add(new ServiceModel
                    {
                        Consultant = new StaffModel
                        {
                            staff_id = (int)reader["Consultant.staff_id"],
                            first_name = (string)reader["Consultant.first_name"],
                            last_name = (string)reader["Consultant.last_name"]
                        },
                    });

                ServiceModel model = services.First((modelA) => { return modelA.Consultant.staff_id == (int)reader["Consultant.staff_id"]; });


                model.Juniors.Add(new StaffModel
                {
                    staff_id = (int)reader["Junior.staff_id"],
                    first_name = (string)reader["Junior.first_name"],
                    last_name = (string)reader["Junior.last_name"]
                });
            }

            return services;
            
        }

        public static void GetAllFromTable(string table)
        {

        }

        public static void RegisterPatient()
        {
            //TODO: Ismael
        }

        public static void ChangeJuniorsService()
        {
            //TODO: Dylan
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
