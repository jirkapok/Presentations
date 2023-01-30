using NUnit.Framework;
using patterns.Layers.New;
using patterns.Layers.Old;

namespace patterns.Layers;

[TestFixture]
public class LayersTests
{
    [Test]
    public void Layers()
    {
        var app = new LayeredApp();
        Assert.That(() =>app.Main(), Throws.Nothing);
    }


    [Test]
    public void Composite()
    {
        var app = new FeaturedApp();
        Assert.That(() => app.Main(), Throws.Nothing);
    }
}