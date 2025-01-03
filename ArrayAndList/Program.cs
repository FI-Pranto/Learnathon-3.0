namespace ArrayAndList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Array Part

            Random ran = new Random();
            //Two type of 2D Array 

            //Rectangular 2D array
            int[,] nums = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nums[i, j] = ran.Next(0,9);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(nums[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //jagged 2D array

            int[][] vals = new int[4][];

            for (int i = 0; i < 4; i++)
            {
                var n = ran.Next(1, 3);
                vals[i]= new int[n];
                for (int j = 0; j < n; j++)
                {
                    vals[i][j] = ran.Next(35, 45);
                }
               
            }
            for (int i = 0; i < 4; i++)
            {
                var n = vals[i].Length;
                for (int j = 0; j < n; j++)
                {
                    Console.Write(vals[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Array Methods

            var arr1 = new int[] { 3,1,2,6,0,4,9,5 };

            Array.Sort(arr1);

            foreach (int i in arr1)
                Console.Write(i+" ");

            Console.WriteLine();

            Array.Reverse(arr1);

            foreach (int i in arr1)
                Console.Write(i+" ");

            Console.WriteLine();

            Console.WriteLine("Array 1 Length : "+arr1.Length);

           var pos= Array.IndexOf(arr1, 6);
            Console.WriteLine(pos);

            Array.Clear(arr1,0,4);

            foreach (int i in arr1)
                Console.Write(i + " ");


            Console.WriteLine();



            //List Part

            List<int> list = new List<int>() { 5,6,1,2};

            list.Add(1);
            var digits=new int[4] {6,7,2,3};

            list.AddRange(digits);

            foreach(var i in list)
                Console.WriteLine(i);

            Console.WriteLine("Count: "+list.Count);

            Console.WriteLine("1st Index of 1 "+list.IndexOf(1));

            Console.WriteLine("Last Index of 1 " + list.LastIndexOf(1));
            Console.WriteLine();

            for(var i=0; i<list.Count; i++)
            {
                if(list[i] == 1)
                {
                    list.Remove(list[i]);
                }
            }
            foreach(var i in list)
                Console.WriteLine(i);

            list.Clear();

            Console.WriteLine("Count after Clear "+list.Count);











        }
    }
}
