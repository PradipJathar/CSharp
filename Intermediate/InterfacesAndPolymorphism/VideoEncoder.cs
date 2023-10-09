using System.Collections.Generic;

namespace InterfacesAndPolymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannel;

        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var channel in _notificationChannel)
            {
                channel.Send(new Message());                                // Depends on channel send method call. and this is polymorphic behavior. 
            }
        }


        public void RegisterNotificationChannel(INotificationChannel notificationChannel)
        {
            _notificationChannel.Add(notificationChannel);
        }
    }
}
