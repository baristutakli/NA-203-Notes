using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CustomProject.Common;
using System.Reflection;

namespace CustomProject.ORM
{
    public class ORMBase<ET,OT> : IORM<ET> 
        where ET : class, new()
        where OT : class, new()
    {
        private static OT _current;
        public static OT Current
        {
            get 
            {
                if (_current == null)
                    _current = new OT();
                return _current;
            }
        }

        public bool Delete(ET entity)
        {
            string query = $"DELETE FROM {TableAtt.TableName} WHERE {TableAtt.PrimaryColumn} = ";

            PropertyInfo[] properties = ETType.GetProperties();
            foreach (var pi in properties)
            {
                if (pi.Name == TableAtt.PrimaryColumn)
                    query += $"{pi.GetValue(entity)};";
            }
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Tools.Connection;
            Tools.Connection.Open();
            int affectedRows = cmd.ExecuteNonQuery();

            Tools.Connection.Close();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public bool Insert(ET entity)
        {
            string command = "INSERT INTO";
            string table = $"{TableAtt.TableName}";
            PropertyInfo[] properties = ETType.GetProperties();
            string props="";
            string values = "";
            // tablo adından sonraki parantez içine gelecek kolon adları.
            foreach (var pi in properties)
            {
                if (pi.Name == TableAtt.IdendityColumn)
                    continue;
                else
                    props += pi.Name +",";
            }
            // en sondaki fazla virgülü siler
            props = props.Remove(props.Length - 1, 1);

            // VALUES () içine gelecek değerler.
            foreach (PropertyInfo pi in properties)
            {
                if (pi.Name != TableAtt.IdendityColumn)
                {
                    if(pi.PropertyType.Name.Contains("String"))
                        values += string.Format("'{0}',",pi.GetValue(entity));
                    else
                        values += string.Format("{0},", pi.GetValue(entity));
                    //values += string.Format("'{0}',",pi.GetValue(entity));
                    //values += $"'{pi.GetValue(entity)}',";
                    Console.WriteLine(pi.Name + "   " + pi.PropertyType);
                }
            }
            // sondaki fazla virgülü sildik.
            values = values.Remove(values.Length - 1, 1);

            string query = $"{command} {table} ({props}) VALUES ({values});";
            //INSERT INTO Shippers(CompanyName, Phone) VALUES('ASD', '123123');
            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Tools.Connection;
            Tools.Connection.Open();
            int affectedRows = cmd.ExecuteNonQuery();

            Tools.Connection.Close();

            if (affectedRows > 0)
                return true;
            else
                return false;

        }

        public Type ETType
        {
            get 
            {
                return typeof(ET);
            }
        }

        public Table TableAtt
        {
            get 
            {
                var attributes = ETType.GetCustomAttributes(typeof(Table), false);
                Console.WriteLine(typeof(Table));

                if (attributes != null && attributes.Any())
                {
                    Table tbl = (Table)attributes[0];
                    //Console.WriteLine(tbl.TableName);
                    //Console.WriteLine(tbl.PrimaryColumn);
                    return tbl;
                }
                return null;
            }
        }

        public List<ET> Select()
        {
            Type type = typeof(ET);
            string query = "SELECT * FROM ";
            var attributes = type.GetCustomAttributes(typeof(Table), false);
            //Any() => Herhangi bir data var ise True döner.
            // null değil ise ve kayıt var ise.
            if (attributes != null && attributes.Any())
            {
                Table tbl = (Table)attributes[0];
                query += tbl.TableName + ";"; // Table attribute tablosundaki ilk eleman TableName
            }
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = query;
            adp.SelectCommand.Connection = Tools.Connection; // connection static Tools sınıfından geldi.
            DataTable dt = new DataTable();
            adp.Fill(dt); // Gelen veriyi dt ye doldurduk.

            return dt.ToList<ET>(); // Burada Tools sınıfında tanımlayıp DataTable'a bind ettiğimiz yani bağladığımız metodu. DataTable nesnesi aracılığı ile kullandık.

        }
        public ET Select(int etID)
        {
            // ETType;
            string query = @"SELECT TOP(1) * FROM {0} WHERE {1}={2}";
            var attributes = ETType.GetCustomAttributes(typeof(Table), false);

            if (attributes != null && attributes.Any())
            {
                Table tbl = (Table)attributes[0];
                query = string.Format(query,tbl.TableName,tbl.PrimaryColumn,etID);
            }

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = query;
            adp.SelectCommand.Connection = Tools.Connection; // connection static Tools sınıfından geldi.
            DataTable dt = new DataTable();
            
            adp.Fill(dt);

            return dt.ToET<ET>();

        }



        public bool Update(ET entity)
        {
            string query = $"UPDATE {TableAtt.TableName} SET ";

            PropertyInfo[] properties = ETType.GetProperties();
            string sets = "";
            // tablo adından sonraki parantez içine gelecek kolon adları.
            foreach (var pi in properties)
            {
                if (pi.Name == TableAtt.IdendityColumn)
                    continue;
                else
                {
                    if (pi.PropertyType.Name.Contains("String") || pi.PropertyType.Name.Contains("Char"))
                        sets += pi.Name + "='" + pi.GetValue(entity) + "',";
                    else
                        sets += pi.Name + "=" + pi.GetValue(entity)+",";
                }
            }

            sets = sets.Remove(sets.Length - 1, 1);
            query += sets;

            foreach (PropertyInfo pi in properties)
            {
                if (pi.Name == TableAtt.PrimaryColumn)
                {
                    if (pi.PropertyType.Name.Contains("String") || pi.PropertyType.Name.Contains("Char"))
                        query += $" WHERE {TableAtt.PrimaryColumn}='{pi.GetValue(entity)}';";
                    else
                        query += $" WHERE {TableAtt.PrimaryColumn}={pi.GetValue(entity)};";
                }
            }

            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Tools.Connection;
            Tools.Connection.Open();
            int affectedRows = cmd.ExecuteNonQuery();

            Tools.Connection.Close();

            if (affectedRows > 0)
                return true;
            else
                return false;

        }
    }
}
