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

            ////created 3 fake giveaways in firm
            //MarketingFirm testFirm = new MarketingFirm(new SweepstakesQueueManager());
            //testFirm.CreateSweepstake();

            Sweepstakes testSweepstakes = new Sweepstakes("test1");
            
            Contestant tester1 = new Contestant();
            tester1.FirstName = "test";
            tester1.LastName = "1";
            tester1.RegistrationNumber = 1;
            tester1.EmailAddress = null; // fill in with temp email

            Contestant tester2 = new Contestant();
            tester2.FirstName = "test";
            tester2.LastName = "2";
            tester2.RegistrationNumber = 2;
            tester2.EmailAddress = null; // fill in with temp email
            
            Contestant tester3 = new Contestant();
            tester3.FirstName = "test";
            tester3.LastName = "3";
            tester3.RegistrationNumber = 3;
            tester3.EmailAddress = null; // fill in with temp email

            testSweepstakes.RegisterContestant(tester1);
            testSweepstakes.RegisterContestant(tester2);
            testSweepstakes.RegisterContestant(tester3);

            testSweepstakes.PrintContestsantInfo(tester1);
            testSweepstakes.PrintContestsantInfo(tester2);
            testSweepstakes.PrintContestsantInfo(tester3);

            Contestant winner = testSweepstakes.PickWinner();
            Console.ReadLine();
         
        }
    }
}
