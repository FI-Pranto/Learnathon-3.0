﻿namespace InterfaceAndPolymorphisom
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Sms...");
        }
    }
}
