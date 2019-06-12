using System;

namespace NoConditionalsSolved.TemplatePattern.Inheritance
{
    internal abstract class AbstractMotion
    {
        private int currentPosition = 0;

        public int UpdatePosition(int position, int increment)
        {
            this.BeforeUpdate(increment);
            int newPosition = position + increment;
            this.AfterUpdate(increment);
            return newPosition;
        }

        protected virtual void BeforeUpdate(int increment)
        {
        }

        protected virtual void AfterUpdate(int increment)
        {
        }

        protected void ApplyAction(string message)
        {
            Console.WriteLine("New position is: '{0}' ({1}).", this.currentPosition, message);
        }
    }
}