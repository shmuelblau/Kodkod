using Investigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public class AgentDTO
    {
        public int Id { get; set; }
        public int IdPlayer { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int PulseSensor {  get; set; }
        public int AudioSensor {  get; set; }
        public int LightSensor {  get; set; }
        public int SignalSensor {  get; set; }
        public int MagneticSensor {  get; set; }
        public int ThermalSensor {  get; set; }


    }
}
