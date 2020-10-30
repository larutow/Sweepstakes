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

        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public Contestant PickWinner()
        {
            return null;
        }

        public void PrintContestsantInfo(Contestant contestant)
        {

        }
    }
}
