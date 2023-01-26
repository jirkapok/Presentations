namespace patterns.ServiceLocator;

public interface IMailSender
{
    void Send(string toAddress, string subject);
}

public class MailSender : IMailSender
{
    public void Send(string toAddress, string subject) { }
}