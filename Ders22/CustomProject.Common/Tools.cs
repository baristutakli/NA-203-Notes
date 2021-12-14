using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CustomProject.Common
{
    public static class Tools
    {
        private static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get 
            { 
                if( _connection == null)
                {
                    _connection = new SqlConnection($"Server=.\\SQLSERVER; Database=Northwind; user=sa; pwd=1234;");
                }
                return _connection;
            }
            set { _connection = value; }
        }


        // where ile ET nin class tipinde olma zorunuluğunu belirttik.
        // aynı şekilde new() ile de bu sınıfın nesne türetilebilir bir sınıf olması 
        // zorunluluğunu belirttik.

        // Method binding: this DataTable ile DataTable sınıfına method ekledik.
        public static List<ET> ToList<ET>(this DataTable dt) where ET:class,new()
        {
            Type type = typeof(ET); // Gelen tip ne? Categories mi, Product mı? Başka birşey mi?  
            List<ET> list = new List<ET>(); // Gelen tip ten nesnelerin olduğu bir liste.
            PropertyInfo[] properties = type.GetProperties(); // Sınıfa ait özellikler bir diziye attık.
            foreach (DataRow dr in dt.Rows)
            {
                ET tip = new ET(); // Categories tip = new Categories();
                foreach (PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name]; // Sınıf özelliğinin adı ile veri tabanındaki tablodan veri çektik.
                    // Yani datarow[CategoryID] dediğimizde oradaki veriye ulaşmış olacağız.
                    if (value != null)
                        pi.SetValue(tip, value);
                }
                list.Add(tip);
            }
            return list;

        }

        public static ET ToET<ET>(this DataTable dt) where ET : class, new()
        {
            Type type = typeof(ET); 
            ET entity = new ET();
            PropertyInfo[] properties = type.GetProperties();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name]; // Sınıf özelliğinin adı ile veri tabanındaki tablodan veri çektik.
                    // Yani datarow[CategoryID] dediğimizde oradaki veriye ulaşmış olacağız.
                    if (value != null)
                        pi.SetValue(entity, value);
                }
            }
            return entity;
        }
    }
}
