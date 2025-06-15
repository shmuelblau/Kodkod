using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Investigation.Classes
{
    public static class Factory
    {
        public static Random Rand = new Random();
        public  static string GetSensorName()
        { 
            List<string> list = Typs.sensors.Keys.ToList();
            return list[Rand.Next(0,list.Count)];

        }


        public static Type GetSensorType() 
        {
            List<Type> list = Typs.sensors.Values.ToList();
            return list[Rand.Next(0, list.Count)];
        }

        public static ISensor CreateSensor(string name)
        {
            Type type = Typs.sensors[name];

            ISensor sensor = (ISensor)Activator.CreateInstance(type);

            return sensor;
        }
    }
}
