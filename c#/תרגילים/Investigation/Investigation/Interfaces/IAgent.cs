using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    internal interface IAgent
    {

        string Name { get; set; }
        List<ISensor> Sensors { get; set; }

        List<string> Weaknesses { get; set; }

       

        void Operate();

        void CreateWeaknesses(int num);


        void AddSensor(string name, int loc);


        string Check();
    }
}
