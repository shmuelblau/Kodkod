using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Classes
{
    public class Agent 
    {
        public List<ISensor> Sensors { get; set; } = new List<ISensor>();

        protected List<string> Weaknesses { get; set; }

        public  Agent(int num) 
        {
            CreateWeaknesses(num);
        }


        private void CreateWeaknesses (int num)
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
            bool check = false;

            if (check)
            {
                return "לא תפסת";
            }
            else
            {
                return "אוקיי נתפסתי";
            }
        }




    }
}
