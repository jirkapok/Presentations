using AutoFixture;
using Autogenerated_TestData.DataStructures;

namespace Autogenerated_TestData;

public class InitializeComplexDataTests
{
    [Test]
    public void Test1()
    {
        var person = new Student("Karel", "Vokurka", DateTime.Today, Guid.NewGuid());

        Assert.That(person.FullName, Is.Not.Null.Or.Empty);
    }

    [Test]
    public void Test1_Autogenerated()
    {
        var person = new Fixture().Create<Student>();

        Assert.That(person.FullName, Is.Not.Null.Or.Empty);
    }

    [Test]
    public void Test1_Autogenerated_Customized()
    {
        var person = new Fixture().Build<Student>()
            .With(p => p.FirstName, "Karel")
            .With(p => p.LastName, "Vokurka")
            .Create();

        Assert.That(person.FullName, Is.EqualTo("Karel Vokurka"));
    }
}