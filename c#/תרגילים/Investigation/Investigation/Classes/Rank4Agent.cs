using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Classes
{
    public class Rank4Agent:Agent , IBaseCounterattack
    {
        public Rank4Agent(string name):base(name , 3) { }

        public void BaseCounterattack()
        {
            Random random = new Random();
            if (counter % 3 == 0)
            {
                Sensors[random.Next(0, Sensors.Count - 1)] = null;
            }
        }
    }
}
