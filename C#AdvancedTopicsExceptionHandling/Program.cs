namespace C_AdvancedTopicsExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = 0;
                var c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Issue of Zero");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Issue with Arithmetics");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Problem");
            }
            finally
            {
                Console.WriteLine("In the finally block");
            }

            try
            {
                using(var streamReader =new StreamReader(@"c:\hi.txt"))//using help to close or dispose the streamReader object 
                    //Or else we have to manually call streamReader.Dispose() is finally block
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch
            {
                Console.WriteLine("issue in line 39 of Main function");
            }

            //Creating my own Exception

            try
            {
                var ytApi = new YouTubeApi();
                var videos = ytApi.GetList("FI");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            

        }
    }
}
