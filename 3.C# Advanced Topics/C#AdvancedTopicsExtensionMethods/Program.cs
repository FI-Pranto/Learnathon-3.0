namespace C_AdvancedTopicsExtensionMethods
{
    public static class Ex
    {

        public static string Shorten(this string s,int n)
        {
            if (n < 0)
                throw new ArgumentException("Invalid Arguments");
            if (n == 0) return "";

            var words = s.Split(" ");

            if (words.Length <= n)
                return s;

            return string.Join(" ",words.Take(n))+"...";
        }

    }


        
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "Hello FI can you tell me blah blah blah";
            //We can not use String class as an Inheritance because it is sealed
            //So to Extend the string class methods and add a new custom method of my own
            //we can use this way of extension method

            var shortendPost = post.Shorten(5);
            Console.WriteLine(shortendPost);
        }

        //to do it 
        //1 - declare a class as static
        //2 - declare the method as static too
        //and in the parameter use (this string VariableName) as an argument and other your arguments

    }
    
}
