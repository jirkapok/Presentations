using patterns.Layers.New.Contracts;

namespace patterns.Layers.FeatureC;

public class UI_C: IView
{
    private readonly IBL bl;

    public UI_C(IBL bl)
    {
        this.bl = bl;
    }

    public void View() { }
}

public class BL_C: IBL
{
    private IDal dal;

    public BL_C(IDal dal)
    {
        this.dal = dal;
    }

    public void Do() { }
}

public class Dal_C: IDal
{
    public void Get() { }
}