using System;

namespace _1_Polymorphism
{
    public class SmsNotficationChannel : INotficationCannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending sms...");
        }
    }
}
