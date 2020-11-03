using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;
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
            EmailAlert(message);
            Console.WriteLine(message.MessageContent);
        }

        public void OnError(Exception error)
        {

        }

        public void EmailAlert(Message message)
        {
            
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("dev test", "larutowdevtest@gmail.com"));
            email.To.Add(new MailboxAddress(FirstName + " " + LastName, EmailAddress));
            email.Subject = "Sweepstakes Results";

            email.Body = new TextPart("plain")
            {
                Text = message.MessageContent
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true);
                //pls no hacko
                client.Authenticate("lrutodevtest@gmail.com", "password goes here");
                //pls dont hack
                client.Send(email);
                client.Disconnect(true);
            }

        }
    }
}
