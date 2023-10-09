using System;

namespace InterfacesAndPolymorphism
{
    public class MailINotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}
