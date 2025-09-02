namespace FunctionalCsharp.UsersRepository;

// for simplicity only
public class User(int id, string name)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
}