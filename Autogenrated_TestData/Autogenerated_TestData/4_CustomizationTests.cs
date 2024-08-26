using AutoFixture;
using AutoFixture.AutoMoq;
using Autogenerated_TestData.DataStructures;

namespace Autogenerated_TestData;

// How do I prevent customization explosion?
public class CustomizationTests
{
    [Test]
    public void Test4_OmitRecursion()
    {
        var fixture = new Fixture();
        // Without this the test will fail with a StackOverflowException
        // see documentation for more build in behaviors
        fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        fixture.Customize(new FixedStringLengthCustomization(5));

        var task = fixture.Create<Task>();
        Assert.That(task.DependsOn, Is.Null);
        Assert.That(task.Title.Length, Is.EqualTo(5));
    }

    [Test]
    public void Test4_MoqCustomization()
    {
        var fixture = new Fixture()
            .Customize(new AutoMoqCustomization());

        var schoolMock = fixture.Create<ISchool>();

        Assert.That(schoolMock, Is.Not.Null);
    }
}

public class FixedStringLengthCustomization(int maxLength) : ICustomization
{
    public void Customize(IFixture fixture)
    {
        fixture.Customize<string>(composer => composer.FromFactory(() => Guid.NewGuid().ToString().Substring(0, maxLength)));
    }
}