namespace c_AdancedTopicsDelegates
{
    class PhotoFilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness Applied..");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize Applied...");
        }
    }
}
