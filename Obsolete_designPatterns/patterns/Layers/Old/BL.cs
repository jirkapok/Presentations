using patterns.Layers.Old.Dal;

namespace patterns.Layers.Old.BL;

public class AppBL: IBL
{
    private IDal dal;

    public AppBL(IDal dal)
    {
        this.dal = dal;
    }

    public void DoA() { }
    public void DoB() { }
    public void DoC() { }
}