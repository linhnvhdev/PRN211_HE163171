using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    public class VideoEventArgs: EventArgs
    {
        public Video Video { get; set; }

        public string Message { get; set; }
    }

    internal class VIdeoEncoder
    {
        public EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video,string message)
        {
            Console.WriteLine("Encoding video...");
            OnVideoEncoded(video,message);
        }

        protected virtual void OnVideoEncoded(Video video,string message)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video,Message = message });
            }
        }
    }
}
