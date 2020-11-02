using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;

        //constructor injection
        //Dependency injection is used to pass in any object which depends on ISweepstakesManager interface (as marketing firm needs to utilize the insertSweepstakes function on the manager)
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstake()
        {
            string sweepstakeName = UserInterface.GetUserInputFor("Please name your new sweepstakes");
            _manager.InsertSweepstakes(new Sweepstakes(sweepstakeName));
        }

    }
}
