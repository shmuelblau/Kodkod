class Letter
{
    public int Id { get; set; }
    public string Type { get; set; }
    public int Date { get; set; }
    public string Content { get; set; }

    public Letter(string data)
    {
        string[] parts = data.Split(':', '|');
        Id = int.Parse(parts[0][1..^1]);
        Type = parts[1][1..^1];
        Date = int.Parse(parts[2][1..^1]);
        Content = parts[3][1..^1];

    }
    public void Print()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Content: {Content}");
    }
}

class LetterManager
{
    Letter[] letters;

    public LetterManager(string[] data)
    {
        letters = new Letter[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            letters[i] = new Letter(data[i]);
        }
    }

    public void PrintLetters()
    {
        Console.WriteLine("Letters:");

        for (int i = 0; i < letters.Length; i++)
        {
            letters[i].Print();
        }

    }

    public void Processing()
    {
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i].Content = letters[i].Content.Trim();
            
            if (letters[i].Date % 2 == 0)
            {
                letters[i].Content = letters[i].Content.ToUpper();
            }

        }
        
    }

    public void PrintImportantMessages()
    {
        Console.WriteLine("Important Messages:");

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i].Type == "QUEST" || letters[i].Type == "URGENT")
            {
                letters[i].Print();
            }
        }
    }

    public void Sorting()

    {
        Array.Sort(letters , (b,a ) => a.Date.CompareTo(b.Date));
        
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        string[] letters = new string[]
        {
    "[1023]:[URGENT]:[20250501]|[System overload in sector 7]",
    "[3456]:[INFO]:[20250428]|[New update available for download]",
    "[7890]:[QUEST]:[20250315]|[Retrieve the ancient artifact from the ruins]",
    "[2345]:[URGENT]:[20250503]|[Unauthorized access detected]",
    "[8765]:[INFO]:[20250220]|[Maintenance scheduled for tomorrow at 03:00]",
    "[4321]:[QUEST]:[20250130]|[Assist the villagers with their harvest]",
    "[6589]:[INFO]:[20250504]|[Password will expire in 3 days]",
    "[9123]:[URGENT]:[20250505]|[          Security breach in Zone 3]"
          };

//   יוצר מערך של מכתבים
    LetterManager letterManager = new LetterManager(letters);
  //    מדפיס הכל
    letterManager.PrintLetters();
    Console.WriteLine("-----------------------------------------------");
  //  מדפיס חשובים 
    letterManager.PrintImportantMessages();
    Console.WriteLine("-----------------------------------------------");
 // מיון לפי תאריך
        letterManager.Sorting();
//   עיבוד 
    letterManager.Processing();
//    מדפיס הכל
    letterManager.PrintLetters();
        Console.WriteLine("-----------------------------------------------");



    }
}