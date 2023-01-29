namespace patterns.AnemicModel;

public class BlogPost
{
    public string Text { get; set; }

    public DateTime? Published { get; private set; }

    public BlogPostStatus Status { get; private set; }

    // Just for Entity framework
    private BlogPost() {}

    public BlogPost(string text, BlogPostStatus status, DateTime? published = null)
    {
        if (string.IsNullOrEmpty(text)) 
            throw new ArgumentException("Text is required");
        
        if (published == null && status == BlogPostStatus.Published) 
            throw new ArgumentException("Published posts need publish dates");

        this.Text = text;
        this.Published = published;
        this.Status = status;
    }

    public void Publish()
    {
        this.Status = BlogPostStatus.Published;
        this.Published = DateTime.UtcNow;
    }
}