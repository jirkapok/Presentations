using patterns.Layers.Old.BL;
using patterns.Layers.Old.Dal;
using patterns.Layers.Old.UI;

namespace patterns.Layers.Old;

public class LayeredApp
{
    public void Main()
    {
        var dal = new AppDal();
        var bl = new AppBL(dal);
        var ui = new AppUI(bl);

        ui.ViewA();
    }
}