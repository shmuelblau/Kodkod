using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation
{
    public static class Operation
    {
       public static void Start()
        {
            while (true)
            {
                int idplayer = printMenu.MainMenu();

                PlayerDTO player = DbManager.GetPlayer(idplayer);

                List<Agent> agents = DbManager.LoadAgentsFromDB(idplayer);

                

            }
        }
    }
}
