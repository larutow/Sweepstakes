using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public Simulation()
        {

        }

        public void CreateMarketingFirmWithManager()
        {
            ManagerTypeFactory managerFactory = new ManagerTypeFactory();

            //prompt for manager type (stack or queue)
            string managerTypeString = UserInterface.GetUSerInputFor("Choose manager type: stack or queue");

            //generate a managerType 
            ISweepstakesManager sweepstakesManagertype = managerFactory.GetManagerType(managerTypeString);

            //generate a firm with thatmanager type
            MarketingFirm firm = new MarketingFirm(sweepstakesManagertype);  
            

        }
    }
}
