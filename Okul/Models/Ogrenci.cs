using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Okul.DataAccess;
namespace Okul.Models

{
    public class Ogrenci
    {   
        public int Id { get; set; }
        public string FistName { get; set; }
        public  string LastName { get; set; }
        public  int  Age { get; set; }

        private int _TeacherId { get; set; }
        public int TeacherId
        { get { return _TeacherId; } set {
                this._TeacherId = value;
               
            }
        }
        private Ogretmen _teacher;
        public Ogretmen Teacher
        {
            get
            {
                if (_teacher is null)
                {
                    _teacher = OgretmenDal.Current.GetTeacherById(TeacherId);
                    
                }
                return _teacher;
            }
            set { _teacher = value;
                _TeacherId = value.Id;
            } }
        public HttpPostedFileBase Photo { get; set; }// fotoğrafı yükleyebilmemizi sağlayan sınıf
        public string PhotoAdress { get; set; }// Fotoğragın adresini tutmak için ara değişken
    }
}