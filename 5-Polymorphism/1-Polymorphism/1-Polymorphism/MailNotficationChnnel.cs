using System;

namespace _1_Polymorphism
{
    public class MailNotficationChnnel : INotficationCannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail... ");
        }
    }
}
