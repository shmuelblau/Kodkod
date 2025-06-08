using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;

using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MySql1.DAL
{
    internal class TableDAL
    {

        public string Tablename { get; set; }

        public DBmaneger DB { get; set; }


        public TableDAL(string name, DBmaneger conn)
        {
            Tablename = name;
            DB = conn;
        }


        //--------------------------------------------------------------
        public MySqlDataReader GetAllTable()
        {
            try
            {

                string query = "SELECT * FROM " + Tablename;
                MySqlDataReader result = DB.FreeRequest(query);


                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                return null;
            }

        }
        //-------------------------------------------------------------------
        public void Insert(object obj)
        {
            if (!Typs.t.ContainsKey(Tablename))
            {
                return;
            }




            List<string> columns = new List<string>();
            List<string> values = new List<string>();


            var props = obj.GetType().GetProperties();

            foreach (var prop in props)
            {
                string name = prop.Name;
                object value = prop.GetValue(obj);

                

                columns.Add($"`{name}`");

                if (value is string)
                {

                    values.Add($"'{value.ToString()}'");
                }
                else if (value is bool)
                {
                    values.Add((bool)value ? "1" : "0");
                }
                else
                {
                    values.Add(value.ToString());
                }
            }
            string c = string.Join(",", columns.ToArray());
            string v = string.Join(",", values.ToArray());

            string Query = $"INSERT INTO `{Tablename}` ({c}) VALUES ({v});";

            DB.FreeNoneRequest(Query);

        }

        public void Update(object obj)
        {
            string Query = "UPDATE " + Tablename + " SET ";
            List<string> strings = new List<string>();

            var props = obj.GetType().GetProperties();
            int id = 1;
            foreach (var prop in props)
            {
                string name = prop.Name;
                object value = prop.GetValue(obj);

                if (name == "id")
                {
                    id = Convert.ToInt32(value);
                }


                if (value is string)
                {

                    strings.Add($"{name} = '{value.ToString()}' ");
                }
                else if (value is bool)
                {
                    Query += $"{name} = {((bool)value ? 1 : 0)} ";
                    strings.Add($"{name} = {((bool)value ? 1 : 0)} ");

                }
                else
                {
                    strings.Add($"{name} = {value.ToString()} ");
                }
            }

            Query += string.Join(",", strings.ToArray());
            Query += $" WHERE id = {id} ;";

            DB.FreeNoneRequest(Query);

        }
        public void Delete(object obj)
        {
            string id = obj.GetType().GetProperty("id").ToString();
            string Query = $"DELETE FROM agents WHERE id = {id};";
            DB.FreeNoneRequest(Query);
        }
        
           

    }






}
