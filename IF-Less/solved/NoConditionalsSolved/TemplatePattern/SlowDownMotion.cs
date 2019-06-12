namespace NoConditionalsSolved.TemplatePattern
{
    internal class SlowDownMotion : IMotion
    {
        private readonly MotionAutomat motionAutomat;

        public SlowDownMotion(MotionAutomat motionAutomat)
        {
            this.motionAutomat = motionAutomat;
        }

        public void BeforeUpdate(int increment)
        {
        }

        public void AfterUpdate(int increment)
        {
            this.motionAutomat.ApplyAction("Enable secondary break sensor.");
        }
    }
}