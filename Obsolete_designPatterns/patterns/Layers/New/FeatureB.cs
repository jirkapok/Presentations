using patterns.Layers.New.Contracts;

namespace patterns.Layers.FeatureB;

public class UI_B: IView
{
    private readonly IBL bl;

    public UI_B(IBL bl)
    {
        this.bl = bl;
    }

    public void View() { }
}

public class BL_B: IBL
{
    private IDal dal;

    public BL_B(IDal dal)
    {
        this.dal = dal;
    }

    public void Do() { }
}

public class Dal_B: IDal
{
    public void Get() { }
}