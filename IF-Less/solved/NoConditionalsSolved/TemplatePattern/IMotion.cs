namespace NoConditionalsSolved.TemplatePattern
{
    internal interface IMotion
    {
        void BeforeUpdate(int increment);

        void AfterUpdate(int increment);
    }
}