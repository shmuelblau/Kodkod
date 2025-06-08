using System;
using System.Collections.Generic;

namespace MySql1.DAL
{
    public static class Typs
     {
          public static readonly Dictionary<string, Type> t = new Dictionary<string, Type>
          {
                 { "Agent",  typeof(Agent)}
           };

        public static void hh() { }
     }

}