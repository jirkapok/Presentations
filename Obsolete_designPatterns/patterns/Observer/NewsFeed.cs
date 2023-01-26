namespace patterns.Observer;

public class NewsFeed
{
    public event EventHandler<string> Received;

    public void Receive(string news)
    {
        this.Received?.Invoke(this, news);
    }
}