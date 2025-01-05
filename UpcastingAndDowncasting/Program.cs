namespace UpcastingAndDowncasting
{
    internal class Program
    {

        class Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public Shape()
            {
                Console.WriteLine("Hello from Shape..");
            }

            public virtual void Draw()
            {
                Console.WriteLine("Draw any shape..");
            }


        }

        class Circle : Shape
        {

            public Circle()
            {
                Console.WriteLine("Hello from circle...");
            }

            public override void Draw()
            {
                Console.WriteLine("Drawing circle..");
            }

            public void Show()
            {
                Console.WriteLine("Show it");
            }


        }

        static void Main(string[] args)
        {
            //Upcasting

            Shape circle=new Circle();
            circle.Draw();
           // circle.Show(); //Error Not accessible

            //Downcasting

            Circle anotherCircle=(Circle)circle;

            anotherCircle.Draw();
            anotherCircle.Show();

            //Using as ,is keyword

            Circle circle1=circle as Circle;

            if (circle1 != null)// using as if the downcasting is not possible it return null
            {
                circle1.Draw();
                circle1.Show();

            }
            Shape shape = new Circle();

            if(shape is Circle)
            {
                Circle circle2=circle as Circle;
            }


        }
    }
}
