namespace InterfaceAndPolymorphisom
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mails....");
        }
    }
}
