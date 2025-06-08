using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("enter mesag");

string str = Console.ReadLine();

File.WriteAllText("secret.txt",str);

string secret = File.ReadAllText("secret.txt");

string encoding = "";

foreach (char c in secret)
{
    if (char.IsLetter(c))
    {
        encoding += (char)(219 - (int)char.ToLower(c));
        
    }
    else
    {
        encoding += c;
    }
}

Console.WriteLine(encoding);