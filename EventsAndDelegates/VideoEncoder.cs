using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs arge);
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video Vidio)
        {
            
            Console.WriteLine("Encoding Video......");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
