using System.Reflection.Metadata;

namespace Ploymorphism_MethodOverridingAndAbstract_
{

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle....");
        }


    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle....");
        }
    }


    class Shape
    {

        public virtual void Draw()
        {
            Console.WriteLine("Draw Any Things..");

        }

    }

    class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Attacking With Arrow..");
        }
    }

    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Attacking With Axe..");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Method Overriding
            List<Shape> list = new List<Shape>();

            list.Add(new Circle());
            list.Add(new Triangle());

            foreach (Shape shape in list)
            {
                shape.Draw();
            }

            //Absract Modifier

          //  Player player = new Player();  // Error Abstract classes can not be intantiated

            var player1=new Archer();

            player1.Attack();

            var player2=new Warrior();
            player2.Attack();

            
        }
    }
}
