namespace InheritanceAndConstructor
{

    class Player
    {
        public string id;
        public Player(string id)
        {
            this.id = id;
            Console.WriteLine("My Player Id {0}",id);
        }
    }

    class Warrior : Player
    {
        public Warrior(string id)
            :base(id)
        {
            Console.WriteLine("My Id {0}",id);
        }
    }
    
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior w=new Warrior("W1234");
        }
    }
}
