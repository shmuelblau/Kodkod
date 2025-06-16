using Investigation;
using Investigation.Classes.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public class PulseSensor: Sensor
    {

        

        public int count { get; set; }

        public PulseSensor(Agent agent) : base("PulseSensor", agent) { }

        public override string Activate()
        {

            count += 1;

            if ( count % 3 == 0)
            {
                Pulse();
            }

            return name;
        }

        public void Pulse()
        {
            for(int i = 0; i < agent.Sensors.Count; i++)
            {
                if (agent.Sensors[i] != null  && agent.Sensors[i] is PulseSensor)
                {
                    agent.Sensors[i] = null;
                }
                
            }
        }
    }


}
