using patterns.Layers.New.Contracts.BL;
using patterns.Layers.New.Contracts.UI;

namespace patterns.Layers.FeatureB.UI
{
    public class UI_B : IView
    {
        private readonly IBL bl;

        public UI_B(IBL bl)
        {
            this.bl = bl;
        }

        public void View() { }
    }
}

namespace patterns.Layers.FeatureB.BL
{
    public class BL_B : IBL
    {
        private IDal dal;

        public BL_B(IDal dal)
        {
            this.dal = dal;
        }

        public void Do() { }
    }
}

namespace patterns.Layers.FeatureB.Dal
{
    public class Dal_B : IDal
    {
        public void Get() { }
    }
}