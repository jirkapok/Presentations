using patterns.Layers.FeatureA;
using patterns.Layers.FeatureB;
using patterns.Layers.FeatureC;
using patterns.Layers.New.Contracts;

namespace patterns.Layers.New;

public class FeaturedApp
{
    public void Main()
    {
        var features = new List<IView>()
        {
            new UI_A(new BL_A(new Dal_A())),
            new UI_B(new BL_B(new Dal_B())),
            new UI_C(new BL_C(new Dal_C()))
        };


        features.First().View();
    }
}