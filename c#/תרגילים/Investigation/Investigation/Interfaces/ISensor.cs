using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public interface ISensor
    {
        Agent agent { get; set; }
        string name { get; set; }

        string Activate();
        


    }
}
