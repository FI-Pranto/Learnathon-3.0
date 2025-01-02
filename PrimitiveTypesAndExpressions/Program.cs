namespace PrimitiveTypesAndExpressions
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //vairable  declare   
            byte x = 25;
            short y = 20000;
            int number = 36732;
            long bigNumber = 477337;
            float price = 2.5f;
            double highPrice = 10.6;
            char letter = 'S';
            decimal myValue = 46.7m;//camel case

            const float PI = 3.1416f;//pascal case for constant 


            Console.WriteLine("{0} {1}", x, y);
            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(price);
            Console.WriteLine(highPrice);
            Console.WriteLine(letter);
            Console.WriteLine(myValue);

            //Type conversion
            //-> Implicit Type Conversion
            byte bt = 10;
            int i = bt;
            float f = i;
            Console.WriteLine(f);

            //->Explicit Type conversion
            int val = 245;
            byte byt = (byte)val;
            Console.WriteLine(byt);

            //Non-Compatible Types
            string s = "100";
            int k = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine("{0} {1}", k, j);


            //Operators
            int a = 10, b = 20, c = 3;
            Console.WriteLine(a + b * c);

            Console.WriteLine(a == b && c == 3);

            b = a++;

            Console.WriteLine("{0} {1}", a, b);

            b = ++a;

            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
