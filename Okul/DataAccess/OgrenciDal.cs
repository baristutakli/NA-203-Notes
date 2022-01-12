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
    public class OgrenciDal
    {
        private static OgrenciDal _Current{get;set;}
        public static OgrenciDal Current
        {
            get
            {
                if (_Current ==null)
                {
                    _Current = new OgrenciDal();
                }
                return _Current;
            }
        }
        public int Create(Ogrenci ogrenci)
        {
            string query = $"Insert into Ogrenci (FirstName, LastName) VALUES  ('{ogrenci.FistName}','{ogrenci.LastName}')";
            int insertedsId= DbTools.Con.Create(query);
            return insertedsId;
        }
    }
}