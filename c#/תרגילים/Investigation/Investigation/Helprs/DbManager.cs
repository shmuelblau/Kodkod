using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace Investigation
{
    public static class DbManager
    {
        public static List<Agent> LoadAgentsFromDB(int idPlyer)
        {
            return null;
        }


        public static PlayerDTO GetPlayer(int idPlyer)
        {
            return null;
        }


    }




    //[DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class InvestigationContext : DbContext
    {
        public DbSet<AgentDTO> agents {  get; set; }
        public DbSet<PlayerDTO> Players {  get; set; }
        


        public InvestigationContext(): base("name=DefaultConnection") { }

    }
}
