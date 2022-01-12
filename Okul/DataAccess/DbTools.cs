﻿using System;
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
        public bool Execute(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            int effectedRows = -1;
            try
            {
                ConnectDB();
                effectedRows= cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DisConnectDB();

            }
            if (effectedRows >= 0)
            {
                return true;
            }
            else
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
                insertedID =(int) cmd.ExecuteScalar();

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

        public List<Ogrenci> Read(string query)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            SqlCommand cmd = new SqlCommand(query,con);
            IDataReader reader;
            try
            {
              ConnectDB();
              reader=  cmd.ExecuteReader();
                while (reader.Read())
                {
                    ogrenciler.Add(
                        new Ogrenci
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            FistName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString()
                        });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DisConnectDB();

            }
            return ogrenciler;
        }
    }
}