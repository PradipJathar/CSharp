using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;                 // Define event based on delegate

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        internal virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });     // Raise the event
            }
        }

    }
}
