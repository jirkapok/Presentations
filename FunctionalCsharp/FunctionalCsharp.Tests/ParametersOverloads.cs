using FunctionalCsharp.UsersRepository;
using LanguageExt;
using Moq;
using NUnit.Framework;

namespace FunctionalCsharp;

[TestFixture]
public class ParametersOverloads
{
    [Test]
    public void CallApi_Consumes_Services()
    {
        var repository = new Mock<IRepository>();
        var logger = new Mock<ILogger>();
        var userId = Guid.NewGuid();

        // How to reduce number of parameters?
        var result = Api.ReportUser(
            repository: repository.Object,
            logger: logger.Object,
            formatUser: _ => "No items 0",
            userId: userId);

        Assert.That(result, Is.EqualTo("No items 0"));
    }
}


public class Api
{
    public static string ReportUser(IRepository repository, ILogger logger, Func<Option<User>, string> formatUser, Guid userId) // ... and more
    {
        var user = repository.LoadUser(userId);
        logger.Warn("Users loaded");
        return formatUser(user);
    }
}

public interface ILogger
{
    void Warn(string message);
}