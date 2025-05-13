using System.Xml.Linq;

class Floo28
{
    public List<string> Present ;
    public List<string> BadPeople;

   public  Floo28()
    {
        Present = new List<string>();
        BadPeople = new List<string>();
        
    }

    public void Entry(string name)
    
    {
        if (Present.Contains(name))
        {
            BadPeople.Add(name);
            Console.WriteLine("ooooooooooooooooooooooooooooo");
           
        }
        else
        {
            Present.Add(name);
        }
        if (BadPeople.Contains(name)) {
            Console.WriteLine("I’m watching you!");
        }
    }
    public void Exit(string name) {
        if (Present.Contains(name) )
        {
            Present.Remove(name);

        }
        else
        {
            BadPeople.Add(name);
            Console.WriteLine("ooooooooooooooooooooooooooooo");
            Console.WriteLine("I’m watching you!");
        }
        if (BadPeople.Contains(name))
        {
            Console.WriteLine("I’m watching you!");
        }


    }
}



