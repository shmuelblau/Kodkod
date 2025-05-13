using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAnalyzer
{
    internal class Program
    {
        public static Dictionary<string, Action<int[]>> fanks = new Dictionary<string, Action<int[]>>
        {

            {"2",s => Console.WriteLine(string.Join(" ",s)) },
            {"3",s => Console.WriteLine(string.Join(" " , s.Reverse().ToArray())) },
            {"4",s => Console.WriteLine(string.Join(" " , s.OrderBy(x => x).ToArray())) },
            {"5",s => Console.WriteLine(s.Max()) },
            {"6",s => Console.WriteLine(s.Min()) },
            {"7",s => Console.WriteLine(s.Average()) },
            {"8",s => Console.WriteLine(s.Count()) },
            {"9",s => Console.WriteLine(s.Sum()) },
        };
        public static void PrintMenu()
        {

            Console.WriteLine("------menu------\nEnter number 1 to enter a series\n" +
                                " number 2 to display the series\n" +
                                " number 3 to display the inverted series\n" +
                                " number 4 to display the sorted series\n" +
                                " number 5 to display the maximum value\n" +
                                " number 6 to display the minimum value\n" +
                                " number 7 to display the average\n" +
                                " number 8 to display the length of the series\n" +
                                " number 9 to display the sum of the entire series\n" +
                                " number 10 exit");
        }

        public static int[] GetNums()
        {
            List<string> arr;
            string input;
            do
            {
                Console.WriteLine("enter nums");
                arr = Console.ReadLine().Split().ToList();
            }
            while (!arr.All(s => int.TryParse(s, out int x)) || arr.Count < 3);
            Console.WriteLine("1111111");
            return arr.Select(x => int.Parse(x)).ToArray();
        }
        static void Main(string[] args)
        {
            int[] series = GetNums();
            int x;
            string input;
            Console.WriteLine("fdfgdg");
            do
            {
                PrintMenu();
                input = Console.ReadLine();
                if (int.TryParse(input, out x) && x < 10 && x > 1)
                    fanks[input](series);
                if (input == "1")
                    series = GetNums();
            }
            while (input != "10");


        }
    }
}
