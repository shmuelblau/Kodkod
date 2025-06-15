using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public  class Agent : IAgent 
    {
        public string Name { get; set; }
        public List<ISensor> Sensors { get; set; } = new List<ISensor>();

        public List<string> Weaknesses { get; set; }

       

        public  Agent(string name , int num ) 
        {
            Name = name;
            CreateWeaknesses(num);
        }

        public virtual void Operate()
        {
            Check();
        }


        public void CreateWeaknesses (int num )
        {
            for (int i = 0; i < num; i++)
            {
                Weaknesses.Add (Factory.GetSensorName());
            }
        }

        public void AddSensor(string name , int loc)
        {
            Sensors[loc] = Factory.CreateSensor(name);
        }

        public string Check()
        {

            List<string> sensorsactiv = Sensors.Select(s => s.Activate()).ToList();

            List<string> sensorsneaded = Weaknesses.Select(w => w ).ToList();

            sensorsactiv.ForEach(s => sensorsneaded.Remove(s));

            if (sensorsneaded.Count > 0)
            {
                return $"find {Weaknesses.Count - sensorsneaded.Count}/ {Weaknesses.Count}";
            }

            else
            {
                return "caught me!";
            }
        }




    }
}
