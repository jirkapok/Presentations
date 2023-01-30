using patterns.Layers.Old.Contracts;

namespace patterns.Layers.Old;

public class UI
{
    private readonly IBL bl;

    public UI(IBL bl)
    {
        this.bl = bl;
    }

    public void ViewA(){}
    public void ViewB() {}
    public void ViewC() {}
}