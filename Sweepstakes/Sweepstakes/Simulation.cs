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
            //create a managerFactory object to expose the GetManagerType method
            ManagerTypeFactory managerFactory = new ManagerTypeFactory();

            //prompt for manager type (stack or queue)
            string managerTypeString = UserInterface.GetUserInputFor("Choose manager type: stack or queue");

            //generate a managerType using the managerFactory object's GetManagerType method (passing in a string)
            ISweepstakesManager sweepstakesManagertype = managerFactory.GetManagerType(managerTypeString);

            //generate a firm with desired manager type
            MarketingFirm firm = new MarketingFirm(sweepstakesManagertype);  
            

        }
    }
}
