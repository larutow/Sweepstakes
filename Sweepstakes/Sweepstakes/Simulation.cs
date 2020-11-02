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
            string managerTypeString = UserInterface.GetUSerInputFor("Choose manager type: Stack or Queue");
            MarketingFirm newFirm;
            switch (managerTypeString)
            {
                case "stack":
                    newFirm = new MarketingFirm(new SweepstakesStackManager());
                    break;
                case "queue":
                    newFirm = new MarketingFirm(new SweepstakesQueueManager());
                    break;
            }
            
        }
    }
}
