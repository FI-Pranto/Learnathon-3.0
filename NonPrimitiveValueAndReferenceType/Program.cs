namespace NonPrimitiveValueAndReferenceType
{


    class Person
    {
        public int age;
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            //Value
            var number = 11;
            Increment1(number);
            Console.WriteLine(number);



            //Reference
            Person person = new Person();
            person.age = 20;
            Increment2(person);
            Console.WriteLine(person.age);

            //another Value Type example
            int a, b;
            a = 10;
            b = a;
            b++;
            Console.WriteLine("a: {0} b: {1} ", a, b);


            //another Reference Type example
            int[] nums = new int[2] { 1, 2 };
            var newNums = nums;
            newNums[0] = 0;
            Console.WriteLine("nums[0]: {0} newNums[0]: {1}", nums[0], newNums[0]);


        }

        public static void Increment1(int number)
        {
            number = number + 1;
        }
        public static void Increment2(Person person)
        {
            person.age += 20;
        }
    }
}
