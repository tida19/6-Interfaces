using System;
using System.Collections.Generic;

namespace _1_Polymorphism
{
    public class VideoEncoder
    {
        // public readonly MailService _mailService;
        private readonly IList<INotficationCannel> _notficationChannel;
        public VideoEncoder()
        {
            _notficationChannel = new List<INotficationCannel>();

        }
        public void Encode(Video video)
        {
            foreach (var channel in _notficationChannel)
                channel.Send(new Message());
        }
        public void RegisterNotficationChnnel(INotficationCannel channel)
        {
            _notficationChannel.Add(channel);
        }
    }
}
