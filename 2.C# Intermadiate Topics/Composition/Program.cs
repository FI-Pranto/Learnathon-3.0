namespace Composition
{

    internal class Program
    {
        static void Main(string[] args)
        {

            DGMotor dm = new DGMotor(new Logger());

            var logger = new Logger();

            Installer ins =new Installer(logger);
            ins.Installing();
            dm.Migrate();

          
        }
    }
}
