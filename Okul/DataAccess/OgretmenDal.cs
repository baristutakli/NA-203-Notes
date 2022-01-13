using Okul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul.DataAccess
{
    public class OgretmenDal
    {
        private static OgretmenDal _Current { get; set; }
        public static OgretmenDal Current
        {
            get
            {
                if (_Current == null)
                {
                    _Current = new OgretmenDal();
                }
                return _Current;
            }
        }
        public int Create(Ogretmen ogretmen)
        {
            string query = $"Insert into Ogretmen (FirstName, LastName,Classroom) VALUES  ('{ogretmen.FistName}','{ogretmen.LastName}','{ogretmen.Classroom}');select CAST(scope_identity() as int);";
            int insertedsId = DbTools.Con.Create(query);
            return insertedsId;
        }
        public List<Ogretmen> GetTeachers()
        {
            string query = "select * from Ogretmen";

            return DbTools.Con.ReadOgretmen(query);
        }
        public Ogretmen GetTeacherById(int id)
        {
            string query = $"select * from Ogretmen where Id ={id};";
            return DbTools.Con.ReadOgretmen(query)[0];// ogrenci listesinin ilk elemannı döndürür
        }
        public bool Update(Ogretmen ogretmen)
        {
            string query = $"Update Ogretmen set FirstName='{ogretmen.FistName}',LastName='{ogretmen.LastName}', Classroom='{ogretmen.Classroom}' where Id='{ogretmen.Id}';";
            return DbTools.Con.Execute(query);
        }
        public bool Delete(Ogretmen ogretmen)
        {
            string query = $"Delete from Ogretmen where Id ={ogretmen.Id};";
            return DbTools.Con.Execute(query);
        }

    }
}