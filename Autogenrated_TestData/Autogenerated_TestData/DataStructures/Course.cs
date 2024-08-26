namespace Autogenerated_TestData.DataStructures;

public class Course(string name, int capacity, List<Student> students)
{
    public string Name { get; init; } = name;
    public int Capacity { get; init; } = capacity;
    public IEnumerable<Student> Students { get; init; } = students;

    public int Available => Capacity - Students.Count();

    public IEnumerable<Student> Seniors => Students.Where(s => s.BirthDate.Year < DateTime.Now.Year - 65);
}