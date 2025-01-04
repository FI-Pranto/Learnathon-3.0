namespace Classes_Methods_
{

    class Point
    {
        public int X;
        public int Y;

        public Point(int x,int y)
        {
            this.X = x;
            this.Y=y;   
            
        }
        public void Move(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentException("newLocation");
            Move(newLocation.X,newLocation.Y);
        }
    }

    class Summation
    {

        public int Add(params int[] points)
        {

            var sum = 0;
            foreach (var point in points)
            {
                sum += point;
            }
            return sum;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method OverLoading

            Point point = new Point(40, 5);
            point.Move(5, 6);
            Console.WriteLine("{0} {1}",point.X,point.Y);
            try
            {
                //point.Move(null);
                point.Move(new Point(100, 20));
                Console.WriteLine("{0} {1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("Error Occured");
            }

            //params

            Summation summation = new Summation();
            Console.WriteLine(summation.Add(1, 2, 3, 4));
            Console.WriteLine(summation.Add(new int[] { 1, 2, 5, 7 ,100}));

            //out
            int numbers;
            var result=int.TryParse("abc", out numbers);
            if (result)
            {
                Console.WriteLine(numbers);
            }
            else
            {
                Console.WriteLine("Error ocuured");
            }

            
        }
    }
}
