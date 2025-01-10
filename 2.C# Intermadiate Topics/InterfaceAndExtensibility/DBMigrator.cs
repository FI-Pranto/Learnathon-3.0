namespace InterfaceAndExtensibility
{
    class DBMigrator
    {
        private readonly ILogger _logger;
        public DBMigrator(ILogger logger)
        {
            this._logger = logger;
            
        }

        public void Migrate()
        {
            _logger.LogInfo("This is the starting Time "+ DateTime.Now);

            _logger.LogInfo("This is the finsish Time "+ DateTime.Now);
        }
    }
}
