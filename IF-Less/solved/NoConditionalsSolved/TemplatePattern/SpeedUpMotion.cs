namespace NoConditionalsSolved.TemplatePattern
{
    internal class SpeedUpMotion : IMotion
    {
        private readonly MotionAutomat motionAutomat;

        public SpeedUpMotion(MotionAutomat motionAutomat)
        {
            this.motionAutomat = motionAutomat;
        }
        public void BeforeUpdate(int increment)
        {
            this.motionAutomat.ApplyAction("Increase sensor sensitivity");
        }

        public void AfterUpdate(int increment)
        {
        }
    }
}