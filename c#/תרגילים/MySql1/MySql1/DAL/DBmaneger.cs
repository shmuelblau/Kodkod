using MySql.Data.MySqlClient;
using MySql1.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Datatypes.Scalar.Types;

class DBmaneger
{
    protected string connStr = "server=localhost;user=root;password=;database=";
    public MySqlConnection _conn = null;

    public Dictionary<string,TableDAL> Tables = new Dictionary<string,TableDAL>();


    

    //------------------------------------------------------------
    public  DBmaneger(string DBName)
    {
        
            _conn = new MySqlConnection(connStr + DBName);
            


    }
    //---------------------------------------------------------------
    public void Open()
    {
        
        _conn.Open();
            

    }
    //----------------------------------------------------------------
    public  void Close()
    {
        
            _conn.Close();
        
    }

    public void AddTable(string TableName)
    {
        Tables[TableName] = new TableDAL(TableName, this);
    }

    //=========================================================
   

    public  MySqlDataReader FreeRequest(string Request)
    {
        
        try
        {
           Open();
            MySqlCommand cmd = new MySqlCommand(Request, _conn);
            

            return cmd.ExecuteReader();

            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error:dddddddd {ex.Message}");
            return null;
        }
    }

    //---------------------------------------------------
    public void FreeNoneRequest(string Request)
    {

        try
        {
            
            var cmd = new MySqlCommand(Request, _conn);
            cmd.ExecuteNonQuery();


            Console.WriteLine("sgdfg");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
           
        }
    }


    public static List<Dictionary<string, string>> ReaderToList(MySqlDataReader data)
    {
        List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

        while (data.Read())
        {
            Dictionary<string, string> dice = new Dictionary<string, string>();


            for (int i = 0; i < data.FieldCount; i++)
            {
                dice[data.GetName(i)] = data.GetValue(i).ToString();
            }
            list.Add(dice);


        }
        return list;
    }

    public static void PrintTable(List<Dictionary<string, string>> data)
    {
        string[] names = data[0].Keys.ToArray();

        Console.WriteLine(string.Join("  ", names));

        foreach (Dictionary<string, string> a in data)
        {
            Console.WriteLine(string.Join("  " , a.Values));
        }
    }

    public static List<object> DiceToObject(List<Dictionary<string,string>> dice)
    {
        return null;
    }


}