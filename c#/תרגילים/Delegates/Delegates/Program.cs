using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {

      

        
        static void Main(string[] args)
        {
            //*******************************************************************
            List<Func<string,string>> list1 = new List< Func<string,string>>
            {
                s => s.ToUpper() ,
                s => s + "!" ,
                s => new string(s.Reverse().ToArray())
            };
            string name = "shmuel";
            
            string result = list1.Aggregate(name , (curr , fan)=> fan(curr));
            // Console.WriteLine(result);
            //*******************************************************************


            List<Predicate<string>> list2 = new List<Predicate<string>>
            {
                s => s.Length > 8 ,
                s => s.Any(char.IsDigit) ,
                s => s.Any(char.IsLower) ,
                s => s.Any(char.IsUpper) ,
                s => !s.Any(a => a == ' ') ,
            };

            string pass = "1234A56a78";

            bool result1 = list2.All(p => p(pass));
            // Console.WriteLine(result1);

            //*******************************************************************

            List<Func<int, int, int>> list3 = new List<Func<int, int, int>>
            {
                (a,b) => a +b,
                (a,b) => a - b,
                (a,b) => a * b,
                (a,b) => a / b,
            };

            List<int> numbers = new List<int> { 3, 2, 4, 2 };
            int initial = 5;

            int result3 = list3.Aggregate((initial), (curr, fan) => fan(curr, numbers.RemoveAt(0)));


        }
    }
}
