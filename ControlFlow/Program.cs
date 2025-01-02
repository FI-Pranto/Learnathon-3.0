namespace ControlFlow
{
    internal class Program
    {

        public enum PlayerState
        {
            Running,
            Jumping,
            Attacking,
        }
        static void Main(string[] args)
        {
            //if and switch case

            var price = 30.9f;

            if(price >=20 && price <= 40)
            {
                Console.WriteLine("Range is Between 20 to 40");
            }
            else if(price >=50 && price <= 70)
            {
                Console.WriteLine("Range is Between 50 to 70");
            }
            else {
                Console.WriteLine("Unkown");
            
            
            }


            var state= PlayerState.Running;

            switch (state)
            {
                case PlayerState.Running:
                    Console.WriteLine("Player Running");
                    break;
                case PlayerState.Jumping:
                    Console.WriteLine("Player Jumping");
                    break;
                case PlayerState.Attacking:
                    Console.WriteLine("Player Attacking");
                    break;
                default:
                    Console.WriteLine("Player is Idle");
                    break;
            }


            //loops

            var name = "FI Pranto";
            int n = name.Length;

            //for loop
            for(var i=0; i < n; i++)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();

            //for each
            foreach(var i in name)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            //while loop
            while (true)
            {
                Console.WriteLine("Enter your name... ");
                var input= Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Name is .. "+input);
                }
            }

            //Random class

            Random ran= new Random();

            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ran.Next(1,100));
            }*/

            const int lengthOfPassWord = 10;

            char[] passKeys = new char[lengthOfPassWord];
            for(var i = 0; i < lengthOfPassWord; i++)
            {
                passKeys[i] =(char)( 'a' + ran.Next(0, 26));
            }

            string password=new string(passKeys);
            Console.WriteLine(password);
            
        }
    }
}
