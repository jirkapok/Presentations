﻿namespace patterns.Immutable;

[TestFixture]
public class ReadOnlyStruct_Csharp8_Tests
{
    [Test]
    public void ReadOnlyStruct()
    {
        var sut = new ReadOnlyStruct("bbb"); // can't { Name ="bbb" };
        // can't sut.Name = "aaa";

        Assert.That(sut.Name, Is.EqualTo("bbb"));
    }

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
    public void ReadOnlyPropertyStruct()
    {
        var sut = new ReadOnlyPropertyStruct("abc");
        var capital = sut.Capital;

        Assert.That(capital, Is.EqualTo("a"));
    }
}