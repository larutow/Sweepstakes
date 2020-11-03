using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Unsubscriber : IDisposable
    {
        private IObserver<Message> subscriber;
        private List<IObserver<Message>> subscribers;
        public Unsubscriber(List<IObserver<Message>> subscribers, IObserver<Message> subscriber)
        {
            this.subscriber = subscriber;
            this.subscribers = subscribers;
        }
        public void Dispose()
        {
            subscribers.Remove(subscriber);
        }
    }
}
