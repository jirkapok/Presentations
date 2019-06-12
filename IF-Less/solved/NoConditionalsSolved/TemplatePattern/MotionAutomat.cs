using System;

namespace NoConditionalsSolved.TemplatePattern
{
    internal class MotionAutomat
    {
        private int currentPosition = 0;

        public void UpdatePosition(int increment)
        {
            IMotion motion = SelectMotion(increment);
            motion.BeforeUpdate(increment);
            this.currentPosition += increment;
            motion.AfterUpdate(increment);
        }

        private IMotion SelectMotion(int increment)
        {
            if (increment <= 5)
                return new SpeedUpMotion(this);

            return new SlowDownMotion(this);
        }

        internal void ApplyAction(string message)
        {
            Console.WriteLine("New position is: '{0}' ({1}).", this.currentPosition, message);
        }
    }
}
