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
            contestants = new Dictionary<int, Contestant>();
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
            //picks a random value from dictionary via the ElementAt method 
            int winnerIDindex = rng.Next(contestants.Count);
            return contestants.ElementAt(winnerIDindex).Value;

        }

        public void PrintContestsantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant name: {contestant.FirstName} {contestant.LastName}");
            Console.WriteLine($"Contestant email: {contestant.EmailAddress}");
            Console.WriteLine($"Contestant registration number: {contestant.RegistrationNumber}");
        }
    }
}