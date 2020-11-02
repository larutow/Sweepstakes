using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simulation newSim = new Simulation();
            //newSim.CreateMarketingFirmWithManager();
            //Console.ReadLine();

            MarketingFirm testFirm = new MarketingFirm(new SweepstakesQueueManager());
            for(int i = 0; i < 3; i++)
            {
                testFirm.CreateSweepstake();
            }

        }
    }
}
