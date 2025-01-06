namespace C_AdvancedTopicsEvents
{

    class VideoEventArgs : EventArgs
    {
        public video Video{ get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder=new VideoEncoder();

            var mailService=new MailService();
            var messageService=new MessageService();

            videoEncoder.videoEncoded += mailService.OnVideoEncoded;
            videoEncoder.videoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(new video() { Title="T1"});
           
        }

        class MailService
        {
            public void OnVideoEncoded(object obj, VideoEventArgs eventArgs)
            {
                Console.WriteLine("Sending Mail......"+eventArgs.Video.Title);
            }
        }
        class MessageService
        {
            public void OnVideoEncoded(object obj, VideoEventArgs eventArgs)
            {
                Console.WriteLine("Sending Mail......"+eventArgs.Video.Title);
            }

        }
    }
}
