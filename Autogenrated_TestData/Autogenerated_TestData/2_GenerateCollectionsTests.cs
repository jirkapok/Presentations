using AutoFixture;

namespace Autogenerated_TestData;

// TODO test cases:
// * Work with date time
// * Customize fixture for generic data creations
// * Generate service structures with Mocks


public class InitializeCollectionsTests
{
    [Test]
    public void Test2()
    {
        var students = new List<Person>()
        {
            new Person("Karel", "Vokurka", DateTime.Today, Guid.NewGuid()),
            new Person("Jan", "Veselý", DateTime.Today, Guid.NewGuid())
            // add more ...
        };
        var course = new Course("Math", 7, students);

        Assert.That(course.Available, Is.EqualTo(5));
    }

    [Test]
    public void Test2_Simplified()
    {
        var students = new Fixture().CreateMany<Person>(2).ToList();
        var course = new Course("Math", 7, students);

        Assert.That(course.Available, Is.EqualTo(5));
    }

    [Test]
    public void Test2_Simplified2()
    {
        var fixture = new Fixture();
        var course = fixture.Build<Course>()
            .With(c => c.Capacity, 7)
            .With(c => c.Students, fixture.CreateMany<Person>(2).ToList())
            .Create();

        Assert.That(course.Available, Is.EqualTo(5));
    }
}