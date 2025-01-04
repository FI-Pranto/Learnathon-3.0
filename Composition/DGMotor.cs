namespace Composition
{
    class DGMotor
    {

        public readonly Logger logger;
        public DGMotor(Logger logger)
        {
           this.logger = logger;
            
        }
        public void Migrate()
        {
            logger.Log("We are migrating........");
        }

    }
}
