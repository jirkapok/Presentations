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
        // use case load service configuration - Not needed, we should be able to recover to default values
        // Not found user, what is your solution?
        // A) Throw not found exception
        // B) Return default/Dummy/Unknown user
        // C) Return Option<User>

        var users = new Users(new StaticUsersRepository());
        var user = users.FindUserById(0);
        // var name = user.Map(u => u.Name.ToUpper())
        //     .IfNone(() => "UNKNOWN");

        Assert.That(user.IsNone, Is.True);
    }
}

public class Users(IRepository repository)
{
    public Option<User> FindUserById(int userId)
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

    public Option<User> LoadUser(int userId)
    {
        // implicit cast to Option
        return users.FirstOrDefault(u => u.Id == userId);
    }
}