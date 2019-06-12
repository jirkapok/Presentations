using Microsoft.Practices.Unity;
using NoConditionalsSolved.IoC.Factory;
using NoConditionalsSolved.Properties;

namespace NoConditionalsSolved.IoC
{
    internal class CompositionRoot
    {
        internal void Run()
        {
            // Use parameters in constructor injection
            // Use plugins for application extensability

            var container = new UnityContainer();
            // Dont mix the store registration name with the name used to resolve the contianers.
            // the registration have to be named, because otherwise last one overrides the previous registration.
            container.RegisterType<IStore, FileStore>("FileStore");
            container.RegisterType<IStore, DatabaseStore>("DatabaseStore");
            container.RegisterType<IStoreStrategy, StoreStrategy>(new InjectionConstructor(typeof(IStore[])));
            container.RegisterType<IStoreFactory, StoreFactory>(new InjectionConstructor(container, Settings.Default.StoreId));

            var strategy = container.Resolve<IStoreStrategy>();
            var store = strategy.GetStore(Settings.Default.StoreId);

            var factory = container.Resolve<IStoreFactory>();
            var store2 = factory.Create();
        }
    }
}
