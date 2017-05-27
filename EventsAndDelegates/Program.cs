using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video()
            {
                Title = "Video 1"
            };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageServece();
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
    public class MailService
    {
        public void OnVideoEncoded(object source , EventArgs e)
        {
            Console.WriteLine("MaliService: Sending an email......");
        }
    }
    public class MessageServece
    {
        public void OnVideoEncoded(object source , EventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message ....");
        }
    }
}
