using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Datatypes.Scalar.Types;

namespace MySql1
{
    internal class Program
    {

        public static void menu(DBmaneger db)
        {
            while (true)
            {
                Console.WriteLine("\n===== תפריט ניהול סוכנים =====");
                Console.WriteLine("1. הצגת כל הסוכנים");
                Console.WriteLine("2. הוספת סוכן חדש");
                Console.WriteLine("3. עדכון סוכן לפי ID");
                Console.WriteLine("4. מחיקת סוכן לפי ID");
                Console.WriteLine("5. יציאה");
                Console.Write("בחר פעולה: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var a = db.Tables["Agents"].GetAllTable();

                        var b = DBmaneger.ReaderToList(a);
                        DBmaneger.PrintTable(b);
                        break;
                    case "2":
                        db.Tables["Agents"].Insert(null);
                        break;
                    case "3":
                        UpdateAgentById();
                        break;
                    case "4":
                        DeleteAgentById();
                        break;
                    case "5":
                        Console.WriteLine("להתראות!");
                        return;
                    default:
                        Console.WriteLine("❌ בחירה לא תקינה.");
                        break;
                }
            }
        }
            static void Main(string[] args)
            {
                DBmaneger agentsEXE = new DBmaneger("agentsEXE");
                agentsEXE.AddTable("Agents");



                menu(agentsEXE);


            }
        
    }
}
