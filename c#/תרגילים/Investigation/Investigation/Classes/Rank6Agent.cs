using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Classes
{
    internal class Rank6Agent: Agent , IBaseCounterattack
    {
        public int counter { get; set; }
        public Rank6Agent(string name) : base(name, 3) { }


        public override void Operate()
        {
            counter += 1;
            BaseCounterattack();
            BaseCounterattack();
            Check();

        }
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
