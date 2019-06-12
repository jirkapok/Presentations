using System;

namespace NoConditionals.TemplatePattern
{
    internal class MotionAutomat
    {
        private int currentPosition = 0;

        public void UpdatePosition(int increment)
        {
            // TODO 3. get rid of both following IF statements.
            if (increment <= 5)
                this.ApplyAction("Increase sensor sensitivity");

            this.currentPosition += increment;

            if (increment > 5)
                this.ApplyAction("Enable secondary break sensor.");
        }

        private void ApplyAction(string message)
        {
            Console.WriteLine("New position is: '{0}' ({1}).", this.currentPosition, message);
        }
    }
}
