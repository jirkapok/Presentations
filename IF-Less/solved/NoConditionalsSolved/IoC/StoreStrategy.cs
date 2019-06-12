using System.Collections.Generic;
using System.Linq;

namespace NoConditionalsSolved.IoC
{
    public class StoreStrategy : IStoreStrategy
    {
        private readonly Dictionary<string, IStore> storePlugins;

        public StoreStrategy(IStore[] storePlugins)
        {
            this.storePlugins = storePlugins.ToDictionary(p => p.GetType().Name, p => p);
        }

        public IStore GetStore(string storeId)
        {
            return this.storePlugins[storeId];
        }
    }
}
