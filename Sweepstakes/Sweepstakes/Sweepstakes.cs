using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Sweepstakes
{
    class Sweepstakes : IObservable<Message>
    {
        private Dictionary<int, Contestant> contestants;
        public List<IObserver<Message>> messagerecipients;
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
            messagerecipients = new List<IObserver<Message>>();
        }
        static Sweepstakes()
        {
            rng = new Random();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
            Subscribe(contestant);
        }

        public Contestant PickWinner()
        {
            //picks a random value from dictionary via the ElementAt method 
            int winnerIDindex = rng.Next(contestants.Count);
            Contestant winner = contestants.ElementAt(winnerIDindex).Value;
            MessageContestants(winner);
            return winner; 

        }

        public void MessageContestants(Contestant winner)
        {
            Message text = new Message();
            foreach(IObserver<Message> recipient in messagerecipients)
            {
                if (!recipient.Equals(winner)){
                    text.MessageContent = $"Sorry you lose. Winner of contest was {winner.FirstName} {winner.LastName}";
                    recipient.OnNext(text);
                }
                else
                {
                    text.MessageContent = $"Congratulations {winner.FirstName} {winner.LastName} you won!";
                    recipient.OnNext(text);
                }
            }
        }

        public void PrintContestsantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant name: {contestant.FirstName} {contestant.LastName}");
            Console.WriteLine($"Contestant email: {contestant.EmailAddress}");
            Console.WriteLine($"Contestant registration number: {contestant.RegistrationNumber}");
        }

        public IDisposable Subscribe(IObserver<Message> observer)
        {
            messagerecipients.Add(observer);
            return new Unsubscriber(messagerecipients, observer);
        }


    }
}