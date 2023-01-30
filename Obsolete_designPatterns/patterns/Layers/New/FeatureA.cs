using patterns.Layers.New.Contracts.BL;
using patterns.Layers.New.Contracts.UI;

namespace patterns.Layers.FeatureA.UI
{
    public class UI_A : IView
    {
        private readonly IBL bl;

        public UI_A(IBL bl)
        {
            this.bl = bl;
        }

        public void View() { }
    }
}

namespace patterns.Layers.FeatureA.BL
{
    public class BL_A : IBL
    {
        private IDal dal;

        public BL_A(IDal dal)
        {
            this.dal = dal;
        }

        public void Do() { }
    }
}

namespace patterns.Layers.FeatureA.Dal
{
    public class Dal_A : IDal
    {
        public void Get() { }
    }
}