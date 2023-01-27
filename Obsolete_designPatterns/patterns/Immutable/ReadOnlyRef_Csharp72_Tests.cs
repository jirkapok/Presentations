namespace patterns.Immutable;

[TestFixture]
public class ReadOnlyRef_Csharp72_Tests
{
    private static ref readonly ContainerClass ProcessClass(ref ContainerClass toModify)
    {
        // toModify = new ContainerClass(); // cant compile
        toModify.Name = "aaa"; // allowed on class
        return ref toModify;
    }

    private static ref readonly ContainerStruct ProcessStruct(ref ContainerStruct toModify)
    {
        // toModify = new ContainerStruct(); // allowed
        toModify.Name = "bbb";
        return ref toModify;
    }

    [Test]
    public void RefReadOnly_On_Class()
    {
        var sut = new ContainerClass();
        var result = ProcessClass(ref sut);
        ProcessClass(ref result);

        Assert.That(sut, Is.EqualTo(result));
        Assert.That(ReferenceEquals(sut, result), Is.True);
        Assert.That(sut.Name, Is.EqualTo(result.Name));
    }


    [Test]
    public void RefReadOnly_On_Struct()
    {
        var sut = new ContainerStruct() { Name = "ccc" };
        var result = ProcessStruct(ref sut);
        ref readonly var result2 = ref ProcessStruct(ref sut);
        // invalid calls:
        // ref readonly var result = ProcessStruct(ref sut);
        // ProcessStruct(ref result);
        // ProcessStruct(ref ProcessStruct(ref sut));
        Assert.That(sut.Name, Is.EqualTo(result.Name));
    }
}