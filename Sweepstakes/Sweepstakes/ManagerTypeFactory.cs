using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerTypeFactory
    {
        public ManagerTypeFactory()
        {

        }

        public ISweepstakesManager GetManagerType(string stringinput)
        {
       
            MarketingFirm firm;
            ISweepstakesManager managerType = null;
            switch (stringinput)
            {
                case "stack":
                    managerType = new SweepstakesStackManager();
                    break;
                    
                case "queue":
                    managerType = new SweepstakesQueueManager();
                    break;

            }
            

            return managerType;
        }

    }
}
