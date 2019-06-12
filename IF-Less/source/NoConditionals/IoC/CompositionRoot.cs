using NoConditionals.Properties;

namespace NoConditionals.IoC
{
    internal class CompositionRoot
    {
        private IStore store;

        internal void Run()
        {
            // TODO 4. add examples how to build controler without IF statements:
            // Use parameters in constructor injection
            // Use plugins for application extensability
            this.store = this.CreateStore();
        }

        private IStore CreateStore()
        {
            if (Settings.Default.StoreId == "DatabaseStore")
                 return new DatabaseStore();

            return new FileStore();
        }
    }
}
