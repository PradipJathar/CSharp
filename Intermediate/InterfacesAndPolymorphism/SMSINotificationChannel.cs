using System;

namespace InterfacesAndPolymorphism
{
    public class SMSINotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}
