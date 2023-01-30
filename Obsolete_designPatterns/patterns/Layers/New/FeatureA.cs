using patterns.Layers.New.Contracts;

namespace patterns.Layers.FeatureA;

public class UI_A: IView
{
    private readonly IBL bl;

    public UI_A(IBL bl)
    {
        this.bl = bl;
    }

    public void View(){}
}

public class BL_A: IBL
{
    private IDal dal;

    public BL_A(IDal dal)
    {
        this.dal = dal;
    }

    public void Do() { }
}

public class Dal_A: IDal
{
    public void Get() { }
}