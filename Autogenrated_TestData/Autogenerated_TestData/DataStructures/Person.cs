namespace Autogenerated_TestData.DataStructures;

public class Person
{
    public Person(string firstName, string lastName, DateTime birthDate, Guid id)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    // and tons of other properties

    public string FullName => $"{FirstName} {LastName}";
}