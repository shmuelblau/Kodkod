using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement
{


    //קלאס שמתאר הוצאה עם כל המידע
    // מצפה למחרוזת בפורמט Name:Category:Date:Amount
    class Expense
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public int Date { get; set; }

        public int Amount { get; set; }

        public Expense(string data)
        {
            string[] parts = data.Split(':');
            Name = parts[0];
            Category = parts[1];
            Date = int.Parse(parts[2]);
            Amount = int.Parse(parts[3]);

        }
        }
    // מנהל רשימת הוצאות
    // מתחיל ריק ואז ניתן להוסיף
    class Manage
    {
        public Expense[] Expenses { get; set; }
        public int aaa { get; set; }

        public int budget { get; set; }
        public Manage()
        {
            aaa = 0;
            Expenses = new Expense[1000];
        }
        // הוספת הוצאה 
        public void AddExpense(string data)
        {
            Expense expense = new Expense(data);
            Expenses[aaa] = expense;
            aaa++;

        }
        // סיכום יומי על פי תאריך  
        //"YYYYMMDD"  בפורמט
        // מחזיר מחרוזת עם כל המידע מסוכם
        public string DailySummary(string data)
        {
            string result = $"Daily expense summary for the date:{data} \n";
            int sum = 0;

            foreach (var expense in Expenses)
            {
                if (expense != null)
                if (expense.Date == int.Parse(data))
                {
                    sum += expense.Amount;
                    result += $"Expense:{expense.Name} Category:{expense.Category} Amount:{expense.Amount}  \n";
                }
            }

            result += $"Total out {sum}";

            return result;
        }
        // מקבל קטגוריה ומחזיר כמה כסף יצא עליה
        
        public string CategoricalSummary(string data)
        {
            string result = $"Total expenses in the category: {data} \n";
            int sum = 0;

            foreach (var expense in Expenses.Where(e => e != null))
            {
                if (expense.Category == data)
                {
                    sum += expense.Amount; 
                }
            }

            result += $"Total out {sum}";

            return result;
        }


        // מחזיר את כל ההוצאות שהמילה מוזכרת בהם או בקטגוריה
        public string WordSearch(string data)
        {
            string result = $"Total expenses in the Word: {data} \n";
            int sum = 0;

            foreach (var expense in Expenses)
            {
                if (expense.Category == data || expense.Name == data)
                {
                    sum += expense.Amount;
                }
            }

            result += $"Total out {sum}";

            return result;
        }
        // מקבל תאריך בפורמט INT ומחזיר את סכום הכסף שיצא באותו יום
        public int DailySum(int data)
        {
            int sum = 0;
            foreach (var expense in Expenses)
            {

                if (expense.Date == data)
                {
                    sum += expense.Amount;
                }
            }
            return sum;
        }
        // מקבל תאריך ומחזיר את המידע על 7 ימים אחורה כולל שינוי באחוזים
        public string weeklySummary(string data)
        {
            string result = "Daily Summary:\n";
            int yesterday = 1;
            int sum = 0;    
            for (int i = 7 ; i > 0 ; i++ )
            {
                sum = DailySum(int.Parse(data)-i);
                // לעשות חישוב נורמלי של שינוי באחוזים
                result += $"Date:{data} Issue:{sum} Change: {sum / yesterday}% Yesterday";
                yesterday = sum;
                
            }



            return result;
        }
        // מדפיס במידה ועברתי את התקציב היומי
        public void BudgetCheck()
        {

            if (budget != 0) {
                int delyBudget = DailySum(Expenses[aaa-1].Date);
                if (delyBudget > budget) {
                    Console.WriteLine("Warning: You have exceeded your spending limit for today.");

                } 
            }
        }

     

        // מחזיר ממוצע יומי או חודשי

        public int AverageDaily(string input)
        {
            int sum = 0;
            bool isDey = input.Length > 4;
            int caunter = 0;

            if (isDey) {

                foreach (var expense in Expenses)
                {
                    if (expense.Date == int.Parse(input))
                        {
                        sum += expense.Amount;
                        caunter++;
                    }
                }
            }
            else {
                foreach (var expense in Expenses)
                {
                    int mahnth = int.Parse(input) * 100;
                    if (expense.Date >= mahnth && expense.Date <= mahnth + 100)
                    {
                        sum += expense.Amount;
                        caunter++;
                    }
                }
            }
            return sum/caunter;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] records = new string[]
                    {
                        "Milk:Groceries:20250501:15",
                        "BusTicket:Transport:20250502:6",
                        "Rent:Housing:20250501:3000",
                        "Electricity:Utilities:20250503:250",
                        "Cinema:Entertainment:20250502:40",
                        "Checkup:Health:20250504:200",
                        "Books:Education:20250501:120",
                        "Vegetables:Groceries:20250503:85",
                        "Pizza:Dining:20250502:60",
                        "Train:Transport:20250504:22"
                    };



            Manage manage = new Manage();
            foreach (var record in records) 
            { 
                manage.AddExpense(record);

            }
            Console.WriteLine("3333");

            while (true)
            {
                Console.WriteLine("Select the actions you want to perform:\r\n\r\nTo add an expense, press 1,\r\n\r\nDaily summary, press 2,\r\n\r\nExpenses by category, press 3.\r\n\r\nLast week calculation, press 4.\r\n\r\nSearch by word, press 5.\r\n\r\nAverage by month or year, press 6.");
                string choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                        Console.WriteLine("Please type the export details in the format" + "Name:Category:Date:Amount");
                        string n = Console.ReadLine();
                        manage.AddExpense(n);
                        Console.WriteLine("Added successfully");
                        break;

                    case "2":
                        Console.WriteLine("Please enter a date in the format: yyyymmdd");
                        string day = Console.ReadLine();
                        Console.WriteLine(manage.DailySummary(day));
                        break;

                    case "3":
                        Console.WriteLine("Please type a category name.");
                        string category = Console.ReadLine();
                        Console.WriteLine(manage.CategoricalSummary(category));
                        break;

                    case "4":
                        Console.WriteLine("Please enter a date in the format: yyyymmdd");
                        string day1 = Console.ReadLine();
                        Console.WriteLine(manage.weeklySummary(day1));
                        break;

                    case "5":
                        Console.WriteLine("Please type a word name.");
                        string word = Console.ReadLine();
                        Console.WriteLine(manage.CategoricalSummary(word));
                        break;

                    case "6":
                        Console.WriteLine("Type month in YYYYMM format or day in YYYYMMDD format");
                        string input = Console.ReadLine();
                        Console.WriteLine(manage.AverageDaily(input));
                        break;

                    default:
                        Console.WriteLine("Wrong choice");
                        break ;
                }

                manage.BudgetCheck();


                Console.WriteLine("To EXIT enter 0 Or anything else to continue");
                string exit = Console.ReadLine();
                if (exit == "0")
                {
                    Console.WriteLine("good lack");
                    break ;
                }


            }

        }

    }
}
