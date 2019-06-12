namespace NoConditionalsSolved.TemplatePattern.Inheritance
{
    internal abstract class MotionAutomat
    {
        private int currentPosition = 0;

        public void UpdatePosition(int increment)
        {
            AbstractMotion motion = SelectMotion(increment);
            this.currentPosition = motion.UpdatePosition(currentPosition, increment);
        }

        private AbstractMotion SelectMotion(int increment)
        {
            if (increment <= 5)
                return new SpeedUpMotion();

            return new SlowDownMotion();
        }
    }
}
