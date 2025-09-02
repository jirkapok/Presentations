using FunctionalCsharp.UsersRepository;
using LanguageExt;
using NUnit.Framework;

namespace FunctionalCsharp;

[TestFixture]
public class OptionForeverTests
{
    [Test]
    public void Conditional_resolves_value()
    {
        // use case configuration - Not needed, we should be able to recover to default values
        // Not found user? - Depends
        var result = Option<int>.Some(7);

        Assert.That(result.IsSome, Is.True);
    }
}

public class Users(IRepository repository)
{
    public Option<User> FindUserById(Guid userId)
    {
        return repository.LoadUser(userId);
    }
}

public class StaticUsersRepository : IRepository
{
    private static readonly List<User> users = new ()
    {
        new User(1, "John"),
        new User(2, "Mary"),
    };

    public Option<User> LoadUser(Guid userId)
    {
        return users.FirstOrDefault();
    }
}