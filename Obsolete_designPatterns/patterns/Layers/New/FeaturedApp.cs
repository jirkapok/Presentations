using patterns.Layers.FeatureA.BL;
using patterns.Layers.FeatureA.Dal;
using patterns.Layers.FeatureA.UI;
using patterns.Layers.FeatureB.BL;
using patterns.Layers.FeatureB.Dal;
using patterns.Layers.FeatureB.UI;
using patterns.Layers.FeatureC.BL;
using patterns.Layers.FeatureC.Dal;
using patterns.Layers.FeatureC.UI;
using patterns.Layers.New.Contracts.UI;

namespace patterns.Layers.New;

public class FeaturedApp
{
    public void Main()
    {
        // Fully implemented IoC, each interface defined by consumer
        var features = new List<IView>()
        {
            new UI_A(new BL_A(new Dal_A())),
            new UI_B(new BL_B(new Dal_B())),
            new UI_C(new BL_C(new Dal_C()))
        };

        features.First().View();
    }
}