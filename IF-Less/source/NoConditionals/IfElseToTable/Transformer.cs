using System;

namespace NoConditionals.IfElseToTable
{
    class Transformer
    {
        public Func<int, bool> CanApply { get; private set; }

        public Func<int, int> Transform { get; private set; }

        public Transformer(Func<int, bool> canApply, Func<int, int> transform)
        {
            this.CanApply = canApply;
            this.Transform = transform;
        }
    }
}