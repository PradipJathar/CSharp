using System;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sending an message... {e.Video.Title}");
        }
    }
}
