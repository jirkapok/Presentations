namespace patterns.Immutable;

[TestFixture]
public class InParameter_Csharp72_Tests
{
    private static void ProcessClass(in ContainerClass toModify)
    {
        // toModify = new ContainerClass(); // cant compile
        toModify.Name = "aaa"; // allowed on class
    }

    private static void ProcessStruct(in ContainerStruct toModify)
    {
        // toModify = new ContainerClass(); // cant compile
        // toModify.Name = "aaa"; // not allowed on struct
    }

    [Test]
    public void InParameter_On_Class()
    {
        var sut = new ContainerClass();
        ProcessClass(sut);
        Assert.That(sut.Name, Is.EqualTo("aaa"));
    }


    [Test]
    public void InParameter_On_Struct()
    {
        var sut = new ContainerStruct() { Name = "bbb" };
        ProcessStruct(sut);
        Assert.That(sut.Name, Is.EqualTo("bbb"));
    }
}