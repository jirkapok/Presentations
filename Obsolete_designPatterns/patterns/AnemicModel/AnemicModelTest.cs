using NUnit.Framework;

namespace patterns.AnemicModel;

[TestFixture]
public class AnemicModelTest
{
    [Test]
    public void Anemic_IsntSafe()
    {
        var post = new AnemicBlogPost(); // able to create invalid data
        post.Status = BlogPostStatus.Published;
        Assert.That(post.DatePublished, Is.Null);
    }

    [Test]
    public void DomainModel_IsSafe()
    {
        // only valid data
        var post = new BlogPost("something", BlogPostStatus.Unknown); 
        post.Publish();
        Assert.That(post.Published, Is.Not.Null);
    }
}