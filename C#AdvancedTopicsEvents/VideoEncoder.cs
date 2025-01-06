namespace C_AdvancedTopicsEvents
{
    class VideoEncoder
    {
        //Steps:-
        //1 - Define a delegate
        //2 - Define Event based on that delegate
        //3 - Raise the event

        //  public delegate void VideoEncoderEventHandler(object obj, VideoEventArgs eventArgs);

        // public event VideoEncoderEventHandler videoEncoded;

        public event EventHandler<VideoEventArgs> videoEncoded;//this the inbuilt way and above commented code are the real methods to do this
        public void Encode(video video)
        {
            Console.WriteLine("Video encoding....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);

        }
        public void OnVideoEncoded(video video)
        {
            if (videoEncoded != null)
            {
                videoEncoded(this,new VideoEventArgs() { Video=video});
            }
        }
    }
}
