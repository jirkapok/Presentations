using patterns.Layers.Old.BL;

namespace patterns.Layers.Old.UI;

public class AppUI: IUI
{
    private readonly IBL bl;

    public AppUI(IBL bl)
    {
        this.bl = bl;
    }

    public void ViewA(){}
    public void ViewB() {}
    public void ViewC() {}
}