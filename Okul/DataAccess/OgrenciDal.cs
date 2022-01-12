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
            string query = $"Insert into Ogrenci (FirstName, LastName) VALUES  ('{ogrenci.FistName}','{ogrenci.LastName}');select CAST(scope_identity() as int);";
            int insertedsId= DbTools.Con.Create(query);
            return insertedsId;
        }

        public List<Ogrenci> GetStudents()
        {
            string query = "select * from Ogrenci";
            
            return DbTools.Con.Read(query);
        }

        public Ogrenci GetStudentById(int id)
        {
            string query = $"select * from Ogrenci where Id ={id};";
            return DbTools.Con.Read(query)[0];// ogrenci listesinin ilk elemannı döndürür
        }

        public bool Update(Ogrenci ogrenci)
        {
            string query = $"Update Ogrenci set FirstName='{ogrenci.FistName}',LastName='{ogrenci.LastName}' where Id='{ogrenci.Id}';";
            return DbTools.Con.Execute(query);
        }
    }
}