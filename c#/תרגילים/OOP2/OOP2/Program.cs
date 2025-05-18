using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListeningDevice device = new ListeningDevice();

            Enemy enamy = new Enemy("muchamad" , 5 , "hamas" , device);

            enamy.Speech("ssssssssss");
            enamy.Speech("ssssssssss");

            device.GetMassagesByEnemy(enamy);

            device.GetMassagesByWord("ss");

            device.GetMassagesByOrganization("hamas");
        }
    }
}
