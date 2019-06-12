using System;

namespace NoConditionalsSolved.IfElseToTable
{
    internal class MeasureTransform
    {
        public Func<int, bool> CanApply { get; set; }
        public Func<int, int> Transform { get; set; }

        public MeasureTransform(Func<int, bool> canApply, Func<int, int> transform)
        {
            this.CanApply = canApply;
            this.Transform = transform;
        }
    }
}