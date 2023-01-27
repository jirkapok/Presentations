namespace patterns.Immutable;

[TestFixture]
public class Records_Csharp9_Tests
{

    [Test]
    public void ReadOnlyRecordStruct()
    {
        var sut = new ReadOnlyRecordStruct("bbb");
        var sut2 = new ReadOnlyRecordStruct() { Name = "bbb" };
        // can't sut.Name = "aaa";

        Assert.That(sut.Name, Is.EqualTo("bbb"));
        Assert.That(sut2.Name, Is.EqualTo("bbb"));
    }

    [Test]
    public void WithKeyWord_Record()
    {
        var record1 = new ReadOnlyRecordStruct("aaa");
        var record2 = record1 with { Name = "bbb" };
        Assert.That(record1.Name, Is.EqualTo("aaa"));
        Assert.That(record2, Is.EqualTo(new ReadOnlyRecordStruct("bbb")));
    }
}