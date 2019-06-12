namespace NoConditionalsSolved.TemplatePattern.Inheritance
{
    internal class SlowDownMotion : AbstractMotion
    {
        protected override void AfterUpdate(int increment)
        {
            this.ApplyAction("Enable secondary break sensor.");
        }
    }
}