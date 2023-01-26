namespace patterns.Observer;

[TestFixture]
public class ObserverTests
{
    private string message;

    [Test]
    public void ServiceLocator()
    {
        var feed = new NewsFeed();
        feed.Received += OnReceived;
        
        feed.Receive("new message");
        Assert.That(this.message, Is.EqualTo("new message"));
    }

    private void OnReceived(object sender, string newMessage)
    {
        this.message = newMessage;
    }
}