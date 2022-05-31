using System;

namespace EventAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 2"};
            var videoEncoder = new VIdeoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncode;
            videoEncoder.VideoEncoded += (source, e) => { Console.WriteLine("######Random Service: Sending video: ...: " + e.Video.Title); };
            videoEncoder.Encode(video,"Here's your shit");
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending email: ...." + e.Video.Title + " " + e.Message);
        }
    }

    public class MessageService
    {
        public void OnVideoEncode(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message Service: Sending email: ...." + e.Video.Title);
        }
    }
}
