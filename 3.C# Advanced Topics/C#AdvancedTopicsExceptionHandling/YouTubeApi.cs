namespace C_AdvancedTopicsExceptionHandling
{

    class YouTubeException : Exception
    {
        public YouTubeException(string message,Exception ex)
            :base(message,ex)
        { 
        }
    }
    class YouTubeApi
    {
        public List<Video> GetList(string user)
        {
            try
            {

                throw new Exception("I Have thrown it..");

            }
            catch (Exception ex)
            {
                throw new YouTubeException ("Exception from YouTubeApi..", ex);
            }
            return new List<Video>();
        }
    }
}
