using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Okul.Models;
namespace Okul.DataAccess
{
    public class DbTools
    {
        static string strConnection = ConfigurationManager.ConnectionStrings
            ["Db_Okul"].ConnectionString;

        SqlConnection con = new SqlConnection(strConnection);
        private static DbTools _Con { get; set; }
        public static DbTools Con
        {
            get
            {
                if (_Con == null)
                {
                    _Con = new DbTools();
                    
                }
                return _Con;
            }
        }

        public bool ConnectDB()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           

        }

        public bool DisConnectDB()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public int Create(string query)
        {
            int insertedID=-1;
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                ConnectDB();
                insertedID = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DisConnectDB();
                
            }
            return insertedID;
        }
    }
}