namespace c_AdancedTopicsDelegates
{
    class PhotoProcessor
    {
        public delegate void PhotoFilterHandeler(Photo photo);

        public void Process(string path,PhotoFilterHandeler handeler)
        {
            var photo=Photo.Load(path);

            handeler(photo);


            photo.Save();
        }
    }
}
