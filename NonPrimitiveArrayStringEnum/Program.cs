namespace NonPrimitiveArrayStringEnum
{
    internal class Program
    {

        public enum PlayerDoingNow : byte
        {
            Attacking=1,//default from zero
            Defending=2,
            Jumping=3,
            Running=4
        }
        static void Main(string[] args)
        {

            //Array Basic
            int[] arr1 = new int[2];
            arr1[0] = 1;
            arr1[1] = 2;
            Console.WriteLine(arr1[1]);

            //String basic

            string firstName = "FI";
            string lastName = "Pranto";

            var msg = string.Format(" Say Hi to {0} {1}", firstName, lastName);
            Console.WriteLine(msg);

            var names = new string[3] { "Akash", "Rafik", "Jibon" };

            string combinedInOne=string.Join(" ", names);
            Console.WriteLine(combinedInOne);

            string message = @"Say Hello
hi bye to fi";
            Console.WriteLine(message);


            //Enum basic

            Console.WriteLine((int)PlayerDoingNow.Attacking);

            //Access using int
            int stateID = 3;
            Console.WriteLine((PlayerDoingNow)stateID);

            //Access using string
            var stateName = "Defending";

            var stateInInt=(PlayerDoingNow)Enum.Parse(typeof(PlayerDoingNow), stateName);//always use var for this 
            Console.WriteLine(stateInInt);




           
        }
    }
}
