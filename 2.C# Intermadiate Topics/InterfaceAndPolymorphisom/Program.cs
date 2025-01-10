namespace InterfaceAndPolymorphisom
{

     class VideoEncoder
    {

        private readonly List<INotificationChannel> _channels;

        public VideoEncoder()
        {
            _channels = new List<INotificationChannel>();
            
        }
        public void Encoder()
        {
            foreach (var channel in _channels)
            {
                channel.Send(new Message());

            }
        }
        public void Adding(INotificationChannel channel)
        {
            _channels.Add(channel);
        }


    }
    interface IShower
    {
        void Show();
    }
    interface IPlayer
    {
        void Play();
    }

    class Video : IShower, IPlayer //multiple inheritance 
    {
        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var encoder=new VideoEncoder();

            encoder.Adding(new MailNotificationChannel());
            encoder.Adding(new SmsNotificationChannel());

            encoder.Encoder();
        }
    }
}
