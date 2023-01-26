using System.Runtime;
using Ninject;

namespace patterns.ServiceLocator;

public class Tests
{
    [Test]
    public void ServiceLocator()
    {
        var kernel = new StandardKernel(); // NinjectIoC
        kernel.Bind<IMailSender>().To<MailSender>();
        var implementation = kernel.Get<IMailSender>();
        Assert.That(implementation, Is.TypeOf<MailSender>());
    }
}