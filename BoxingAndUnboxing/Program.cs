using System.Collections;

namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            Object val = 10; 
            Console.WriteLine(val);

            //Unboxing
            int num=(int)val;
            Console.WriteLine(num);

            ArrayList arrayList = new ArrayList(); //it has a object as argument 
            //it do boxing when taking adding and unboxing when accessing;

            arrayList.Add(1);
            arrayList.Add("FI");
            arrayList.Add(2.5f);

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
