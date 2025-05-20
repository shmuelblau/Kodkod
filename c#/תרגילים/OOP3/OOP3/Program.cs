using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> temes = new List<Team> {
            new FloodsTeam("ti", 1, true),
            new FloodsTeam("t2", 2, true),
            new InjuriesTeam("t3", 1, true),
            new InjuriesTeam("t4", 2, true),
            new BlockagesTeam("t5", 1, true),
            new BlockagesTeam("t6", 2, true)

            };

            Report[] reports = new Report[]
            {
                new Report("Floods" ,1 ,5 , "dsgrg"),
                new Report("Floods" ,1 ,5 , "dsgrg"),
                new Report("Injuries" ,1 ,5 , "dsgrg"),
                new Report("Injuries" ,2 ,5 , "dsgrg"),
                new Report("Blockages" ,1 ,5 , "dsgrg"),
                new Report("Blockages" ,2 ,5 , "dsgrg")
            };

            

            foreach (Report report in reports) 
                Management.SendTeam(temes, report);
                   


        
        }
    }

}

