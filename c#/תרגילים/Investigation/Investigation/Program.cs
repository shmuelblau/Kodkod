using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Investigation
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // טריק שמכריח את Visual Studio לכלול את ה-DLL בריצה
            var _ = typeof(MySql.Data.MySqlClient.MySqlProviderServices);



            InvestigationContext db = new InvestigationContext();
            PlayerDTO player = new PlayerDTO();
            player.Name = "gn";
            db.Players.Add(player);

        }
    }
}
