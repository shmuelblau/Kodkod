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

        static void Main(string[] args)
        {
            Series series = new Series();
            if (!series.SetSeries(args))
            {
                series.GetNew();
            }

            do
            {

            }
        }
    }
}
