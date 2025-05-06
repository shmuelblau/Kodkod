using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement
{

    class Manage
    {

    }

    class Expense
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public int Date { get; set; }

        public string Amount { get; set; }

        public Expense(string data)
        {
            string[] parts = data.Split(':');
            Name = parts[0];
            Category = parts[1];
            Date = int.Parse(parts[2]);
            // Amount = int.Parse(parts[3]);

        }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
