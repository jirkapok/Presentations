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

        /// <summary>
        /// https://codegolf.stackexchange.com/questions/38033/increment-every-number-in-a-string/38116#38116
        /// </summary>
        public static string Move(string source)
        {
            var a = source.ToCharArray();

            for (int b = 3, c, i = a.Length; i-- > 0;
                b = 48 > c | c > 57
                    ? 7
                    : b > 2
                        ? c > 56 ? a[i] = '0' : ++a[i] * 0
                        : b
            ) c = a[i];

            return new string(a);
        }
    }
}
