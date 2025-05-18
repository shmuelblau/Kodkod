

using System;
using System.Collections.Generic;

public class ListeningDevice
{
    public string Manufacturer { get; set; }
    public int Battery { get; set; } = 50;
    public bool Status { get; set; } = true;
    public string EnemyName { get; set; }

    public Dictionary<Enemy, List<string>> Messages { get; set; } = new Dictionary<Enemy, List<string>>();

    

    public void Speech(Enemy sender, string msg)
    {
        if (Battery > 0)
        {
            if (Messages.ContainsKey(sender)) { Messages[sender].Add(msg); }
            else { Messages[sender] = new List<string> { msg }; }
            Battery -= 5;
            Console.WriteLine($"New message received: {sender.Name} Send {msg} \r\n battery is {Battery}");




        }

        else { Console.WriteLine("no battery"); }

    }


    public void Claim(int num) { Battery += num; }

    public void GetMassagesByEnemy(Enemy sender)
    {
        if (Messages.ContainsKey(sender))
        {
            Console.WriteLine($"messages for {sender.Name}: \r\n" + string.Join("\r\n", Messages[sender]));
        }

        else { Console.WriteLine("no messages "); }

    }

    public void GetMassagesByWord(string word)
    {
        string result = "";

        foreach (var sender in Messages) 
        {
            foreach(string msg in sender.Value)
            {
                if (msg.Contains(word))
                    result += $" {sender.Key.Name} send :   {msg} \r\n";
            }
        }
        Console.WriteLine(result);
    }

    public void GetMassagesByOrganization(string org)
    {
        string result = $"messages in {org} Organization \r\n";

        foreach (var sender in Messages)
        {
            if (sender.Key.Organization == org)
            {
                result += $"messages for {sender.Key.Name}: \r\n" + string.Join("\r\n", sender.Value);
            }


            
        }
        Console.WriteLine(result);
    }
}

