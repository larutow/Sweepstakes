using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sweepstakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private static Random rng;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Sweepstakes(string name)
        {
            Name = name;
        }
        static Sweepstakes()
        {
            rng = new Random();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            int winnerIDindex = rng.Next(contestants.Count);
            return contestants.ElementAt(winnerIDindex).Value;

        }

        public void PrintContestsantInfo(Contestant contestant)
        {
            
        }
    }
}
