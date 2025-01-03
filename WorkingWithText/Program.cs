using System.Text;

namespace WorkingWithText
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fullName = "FI Pranto ";

            Console.WriteLine("Trim : "+fullName.Trim());

            Console.WriteLine("ToUpper : "+fullName.ToUpper());

            var index=fullName.IndexOf(" ");
            
            var firstName=fullName.Substring(0, index);
            var lastName=fullName.Substring(index+1);

            Console.WriteLine("First Name : "+firstName);
            Console.WriteLine("Last Name : "+lastName);

            string[] names = fullName.Split(" ");
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);


            if (string.IsNullOrWhiteSpace(""))
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine(fullName.Replace("FI","King"));

            float price = 29.56f;
            Console.WriteLine(price.ToString("c0"));

            Console.WriteLine();
            //Summarising

            var s = "Hi it is FI Pranto Who is really really really.....";

            Console.WriteLine(StringShorter.Summarize(s));

            Console.WriteLine();

            //String Builder

            StringBuilder mutableString = new StringBuilder();

            mutableString.Append("Hello World");
            mutableString.AppendLine();
            mutableString.Append("FI Pranto");

            Console.WriteLine(mutableString[0]);

            var builder = new StringBuilder();

            builder.Append('h', 10);
            Console.WriteLine(builder);
            builder.Replace('h', 'H');
            Console.WriteLine(builder);
            builder.Remove(0, 5);
            Console.WriteLine(builder);
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            //Procedural Programming

            Console.WriteLine("What is your Name?..");
            var name=Console.ReadLine();
            var reversed=GetReversed(name);
            Console.WriteLine("Reversed Name: "+reversed);






            
        }
        public static string GetReversed(string name)
        {
            var n=name.Length;
            char[] val=new char[n];

            for(int i = n-1; i>=0; i--)
            {
                val[n - i-1] = name[i];

            }

            return new string(val);
        }
    }
}
