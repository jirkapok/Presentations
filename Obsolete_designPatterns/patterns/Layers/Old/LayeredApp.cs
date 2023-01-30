using patterns.Layers.Old.BL;
using patterns.Layers.Old.Dal;
using patterns.Layers.Old.UI;

namespace patterns.Layers.Old;

public class LayeredApp
{
    public void Main()
    {
        // Partially implemented IoC, interfaces are defined by each layer it self
        // in order they are defined.
        var dal = new AppDal();
        var bl = new AppBL(dal);
        var ui = new AppUI(bl);

        ui.ViewA();
    }
}