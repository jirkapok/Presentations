using System.Diagnostics;

namespace DebuggingTipsAndTricks
{
    internal class DataItem
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string privateKey = "Secured private Key";

        public string Name { get; private set; }

        public DataItem(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return string.Format("DataItem:'{0}'", this.Name);
        }
    }
}
