using System;

namespace _1_Polymorphism
{

    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotficationChnnel(new MailNotficationChnnel());
            encoder.RegisterNotficationChnnel(new SmsNotficationChannel());
            encoder.Encode(new Video());
            Console.Read();
        }
    }
}
