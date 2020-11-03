using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : IObserver<Message>
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        public void OnCompleted()
        {

        }

        public void OnNext(Message message)
        {
            Console.WriteLine(message.MessageContent);
        }

        public void OnError(Exception error)
        {

        }
    }
}
