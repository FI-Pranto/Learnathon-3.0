namespace Composition
{
    class Installer
    {
        public Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }
        public void Installing()
        {
            logger.Log("Installing the process....");
        }
    }
}
