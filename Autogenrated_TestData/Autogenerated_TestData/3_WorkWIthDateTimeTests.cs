using AutoFixture;
using Autogenerated_TestData.DataStructures;

namespace Autogenerated_TestData;

public class WorkWithDateTimeTests
{
    [Test]
    public void Test3()
    {
        var students = new List<Student>()
        {
            new ("Jan", "Smutný", DateTime.Today.AddYears(-63), Guid.NewGuid()),
            new ("Karel", "Vokurka", DateTime.Today.AddYears(-68), Guid.NewGuid()),
            new ("Jan", "Veselý", DateTime.Today.AddYears(-73), Guid.NewGuid()),
        };
        var course = new Course("Math", 7, students);

        Assert.That(course.Seniors.Count(), Is.EqualTo(2));
    }

    [Test]
    public void Test3_Simplified()
    {
        var fixture = new Fixture();

        // TODO fix duplicit creation
        var yerOffsets = new Queue<int>(new []{ 63, 68, 73, 63, 68, 73, });
        fixture.Customize<Student>(c => c.With(p => p.BirthDate, () => DateTime.Today.AddYears(-yerOffsets.Dequeue())));

        var course = fixture.Create<Course>();

        Assert.That(course.Seniors.Count(), Is.EqualTo(2));
    }

    [Test]
    public void Test3_FixValue_Stop_TheTime()
    {
        // Another use case Entity Framework DbContextOptions<MyOptions> to share connection
        var fixedDate = new DateTime(2020, 3, 7);
        var fixture = new Fixture();
        fixture.Customize<DateTime>(c => c.FromFactory(() => fixedDate));

        var studentA = fixture.Create<Student>();
        var studentB = fixture.Create<Student>();
        Assert.That(studentA.BirthDate, Is.EqualTo(studentB.BirthDate));
    }
}