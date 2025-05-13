using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
{

    class Series
    {
        public int[] series;

        public void GetNew()
        {
            string input;
            do
            {
                Console.WriteLine("enter nums");
                input = Console.ReadLine();
                

                

            }
            while ( ! SetSeries(input));
            
        }

        public bool SetSeries(string[] str)
        {
            try
            {


                int[] nums = new int[str.Length];

                for (int i = 0; i < str.Length; i++)
                {
                    nums[i] = int.Parse(str[i]);
                }

                if (nums.Length > 2)
                {
                    series = nums;
                    return true;
                }
            }
            catch { return false; }
            return false;

        }

        public bool SetSeries(string s)
        {
            try
            {
                string[] str = s.Split(' ');

                int[] nums = new int[str.Length];

                for (int i = 0; i < str.Length; i++)
                {
                    nums[i] = int.Parse(str[i]);
                }

                if (nums.Length > 2)
                {
                    series = nums;
                    return true;
                }
            }
            catch { return false; }
            return false;

        }


        public void Show()
        {
            foreach (int num in series)
            {
                Console.Write(num + " ");
            }
        }

        public void ShowRevers()
        {

            for (int i = series.Length - 1; i >= 0; i++)
            {
                Console.WriteLine(series[i]);
            }
        }

        public void sort()
        {
            int[] newSeries = (int[])series.Clone();

            for (int i = 0; i < newSeries.Length; i++)
            {
                for (int j = 0; j < newSeries.Length; j++)
                {
                    if (newSeries[i] > newSeries[j])
                    {
                        int temp = newSeries[i];
                        newSeries[i] = newSeries[j];
                        newSeries[j] = temp;
                    }
                }
            }

            foreach (int num in newSeries) { Console.Write(num); }
        }

        public void Max()
        {
            int big = 0;
            foreach (int num in series)
            {
                if (num > big) { big = num; }
            }
            Console.WriteLine(big);
        }

        public void min()
        {
            int min = series[0];
            foreach (int num in series)
            {
                if ( num < min) { min = num; }
            }
            Console.WriteLine(min);
        }


        public void Avarage() 
        { 
             int sum = 0;
            foreach(int num in series) {  sum += num; }
            Console.WriteLine(sum / series.Length);
        }

        public void len() { Console.WriteLine(series.Length); }

        public void Som() 
        {
            int sum = 0;
            foreach (int num in series) { sum += num; }
            Console.WriteLine(sum);
        }


    }
    internal class Program
    {

        static void PrintMenu()
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

        static void Main(string[] args)
        {

            Series series = new Series();

            if (!series.SetSeries(args))
            {
                series.GetNew();
            }

            string chois;

            do
            {
                PrintMenu();
                chois = Console.ReadLine();
                switch (chois) 
                {
                    case "1":
                        {
                            series.GetNew();
                            break;
                        }
                    case "2":
                        {
                            series.Show();
                            break;
                        }
                    case "3":
                        {
                            series.ShowRevers();
                            break;
                        }
                    case "4":
                        {
                            series.sort();
                            break;
                        }
                    case "5":
                        {
                            series.Max();
                            break;
                        }
                    case "6":
                        {
                            series.min();
                            break;
                        }
                    case "7":
                        {
                            series.Avarage();
                            break;
                        }
                    case "8":
                        {
                            series.len();
                            break;
                        }
                    case "9":
                        {
                            series.Som();
                            break;
                        }
                    case "10":
                        {
                            break;
                        }
                }
            }
            while (chois != "10");
            Console.WriteLine("goodbye");
        }
    }
}
