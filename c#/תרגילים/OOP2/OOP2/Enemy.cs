using System;

public class Enemy
{
    public string Name { get; set; }
    public int Rank { get; set; }
    public string Organization { get; set; }

    public ListeningDevice listeningDevice { get; set; }

    public Enemy (string name, int rank, string organization, ListeningDevice listeningDevice)
    {
        Name = name;
        Rank = rank;
        Organization = organization;
        this.listeningDevice = listeningDevice;
    }

    public void Speech(string msg)
    {
        if (listeningDevice != null)
        {
            listeningDevice.Speech(this, msg);
        }
        else { Console.WriteLine("no Device listening"); }
    }

}