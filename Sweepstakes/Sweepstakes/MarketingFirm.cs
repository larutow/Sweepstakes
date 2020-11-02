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

        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstake()
        {
            string sweepstakeName = UserInterface.GetUSerInputFor("Please name your new sweepstake");
            _manager.InsertSweepstakes(new Sweepstakes(sweepstakeName));
        }

    }
}
