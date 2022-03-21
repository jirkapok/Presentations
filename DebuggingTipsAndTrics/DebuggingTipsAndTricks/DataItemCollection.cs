using System.Collections.Generic;
using System.Diagnostics;

namespace DebuggingTipsAndTricks
{
    /// <summary>
    /// https://msdn.microsoft.com/cs-cz/library/ms228992(v=vs.110).aspx
    /// </summary>
    // [DebuggerTypeProxy(typeof(DataItemCollectionDebugView))] // or use the DebuggerBrowsableState
    [DebuggerDisplay("Count:{items.Count}")]
    internal class DataItemCollection
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        private List<DataItem> items = new List<DataItem>()
                {
                    new DataItem("Lemon"),
                    new DataItem("Banana"),
                    new DataItem("Orange"),
                };

        private class DataItemCollectionDebugView
        {
            public DataItemCollection Collection { get; private set; }

            public DataItemCollectionDebugView(DataItemCollection collection)
            {
                this.Collection = collection;
            }
        }
    }
}