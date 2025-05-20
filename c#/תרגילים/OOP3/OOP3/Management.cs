using System;
using System.Collections.Generic;

public static class Management
{
    public static void SendTeam(List<Team> teams ,Report report)
    {
        Team f = teams.Find(x => x.canHelp(report));

        if (f != null)
        {
            Console.WriteLine($"send a team {f._Name}");
            f._Available=false;
            f.handling();
        
        }
    }
}