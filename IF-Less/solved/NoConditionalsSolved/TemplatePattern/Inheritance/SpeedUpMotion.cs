namespace NoConditionalsSolved.TemplatePattern.Inheritance
{
    internal class SpeedUpMotion : AbstractMotion
    {
        protected override void BeforeUpdate(int increment)
        {
            this.ApplyAction("Increase sensor sensitivity");
        }
    }
}