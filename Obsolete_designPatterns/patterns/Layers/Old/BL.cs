using patterns.Layers.Old.Contracts;

namespace patterns.Layers.Old;

public class BL: IBL
{
    private Dal dal;

    public BL(Dal dal)
    {
        this.dal = dal;
    }

    public void DoA() { }
    public void DoB() { }
    public void DoC() { }
}