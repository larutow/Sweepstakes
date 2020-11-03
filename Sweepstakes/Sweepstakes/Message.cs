using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Message
    {
        private string _messageContent;
        public string MessageContent
        {
            get
            {
                return _messageContent;
            }
            set
            {
                _messageContent = value;
            }
        }

    }
}
