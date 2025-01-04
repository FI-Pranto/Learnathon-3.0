namespace Classes_Constructors_
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Enemey drone = new Enemey("Drone",100);

            Console.WriteLine("{0} {1}",drone.name,drone.hpLevel);
         


           
        }
    }
}
