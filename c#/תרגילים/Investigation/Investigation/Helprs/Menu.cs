using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public static class printMenu
    {
        public static int MainMenu()
        {
            string MainMenu = " \r \n היי ברוך הבא ";
                            
            Console.WriteLine(MainMenu);
            while (true)
            {
                Console.WriteLine("בחר מספר שחקן");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n > -1 ) { return n; }
                    else { Console.WriteLine("to big"); }
                }
                catch
                {
                    Console.WriteLine("is not int");
                }
            }


        }public static int PlayerMenu(int num , string name)
        {
            string MainMenu = $" \r \n היי {name} ברוך הבא " +
                              $" יש לך {num} סוכנים  בדרגות שונות לנסות לחקור ";
            Console.WriteLine(MainMenu);
            while (true)
            {
                Console.WriteLine("בחר מספר סוכן");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n > -1 && n< num) { return n; }
                    else { Console.WriteLine("to big"); }
                }
                catch
                {
                    Console.WriteLine("is not int");
                }
            }


        }
    }
}
