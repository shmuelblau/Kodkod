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
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public int NeedSensor {  get; set; }
        public int HaveSensor {  get; set; }
    }
}
