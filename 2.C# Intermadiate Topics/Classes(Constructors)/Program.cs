namespace Classes_Constructors_
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Enemy drone = new Enemy("Drone",100);

            Console.WriteLine("{0} {1}",drone.name,drone.hpLevel);

            //Object initializations
            Enemy enemy = new Enemy()
            {
                name="Kai",
                hpLevel=200
            };
            Console.WriteLine("{0} {1}",enemy.name,enemy.hpLevel);
         


           
        }
    }
}
