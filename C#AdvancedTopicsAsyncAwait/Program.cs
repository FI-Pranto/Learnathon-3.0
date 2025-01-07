namespace C_AdvancedTopicsAsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //async await help to maintain the main thread and give ability of parallel processing

            //Must Give this function async Task as a signature 
            Console.WriteLine("Starting The Application...");

            string result = await DownloadData();
            Console.WriteLine(result);
            
        }
        public static async Task<string> DownloadData()
        {
            Console.WriteLine("Downloading Data....");
            Thread.Sleep(3000);

            Console.WriteLine("Downloded Successfully...");

            return "Downloaded File";
        }
    }
}
