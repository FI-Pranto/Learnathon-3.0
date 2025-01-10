namespace C_AdvancedTopicsDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //similar to python type changing 
            dynamic name = "FI Pro";
            name = 10.5f;//the same variable is converted to float when float assigned
            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 20;
            var c = a + b;//because a and b both dynamic c will also become dynamic because of var

            //type conversion
            int i = 5;
            dynamic d = i;
            long l = d;//d is now int and long can hold int so no problem


        }
    }
}
