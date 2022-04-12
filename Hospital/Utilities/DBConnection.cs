using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Hospital.Utilities
{
    static class DBConnection
    {
        public static string ServerURL { get; private set; }

        static SqlConnection connection;


        public static void SetURL(string URL)
        {
            ServerURL = URL;
            connection = new SqlConnection();
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
