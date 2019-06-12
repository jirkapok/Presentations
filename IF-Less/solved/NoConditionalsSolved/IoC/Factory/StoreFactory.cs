using Microsoft.Practices.Unity;

namespace NoConditionalsSolved.IoC.Factory
{

    public class StoreFactory : IStoreFactory
    {
        private readonly IUnityContainer container;

        private readonly string storeId;

        public StoreFactory(IUnityContainer container, string storeId)
        {
            this.container = container;
            this.storeId = storeId;
        }

        public IStore Create()
        {
            return container.Resolve<IStore>(storeId);
        }
    }
}
