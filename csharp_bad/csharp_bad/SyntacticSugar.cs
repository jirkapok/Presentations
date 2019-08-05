using System;

namespace csharp_bad
{
    public class SyntacticSugar
    {
        private string backField;

        //public string get_PropA() { return backField; }

        public string PropA
        {
            get { return backField; }
            set { backField = value; }
        }

        public string PropB
        {
            get => backField;
            set => backField = value;
        }

        public string PropE { get; set; }

        public string PropC { get { return backField; } }

        public string PropD => backField;
    }
}
