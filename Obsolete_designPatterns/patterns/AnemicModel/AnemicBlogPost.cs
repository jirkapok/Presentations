namespace patterns.AnemicModel;

public class AnemicBlogPost
{
    public string Text{ get; set; }

    public DateTime? DatePublished { get; set; }

    public BlogPostStatus Status { get; set; }
}