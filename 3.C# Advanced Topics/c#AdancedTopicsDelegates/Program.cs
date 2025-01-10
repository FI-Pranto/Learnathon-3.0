namespace c_AdancedTopicsDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var filter=new PhotoFilter();
            PhotoProcessor.PhotoFilterHandeler handler = filter.ApplyBrightness;
            handler += filter.Resize;
            handler += Zoom;

            var processor=new PhotoProcessor();
            processor.Process("Hello.jpg",handler);

            //we already have inbuilt delegates of type generic with 1 to highest 16 parameters

            //Action<> for void methods
            //Func<> for return type 
            //Just replace the custom with Action<Photo> 
        }

        public static void Zoom(Photo photo)
        {
            Console.WriteLine("Zooming...");
        }
    }
}
