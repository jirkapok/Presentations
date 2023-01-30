using patterns.Layers.New.Contracts.BL;
using patterns.Layers.New.Contracts.UI;

namespace patterns.Layers.FeatureC.UI
{
    public class UI_C : IView
    {
        private readonly IBL bl;

        public UI_C(IBL bl)
        {
            this.bl = bl;
        }

        public void View() { }
    }
}

namespace patterns.Layers.FeatureC.BL
{
    public class BL_C : IBL
    {
        private IDal dal;

        public BL_C(IDal dal)
        {
            this.dal = dal;
        }

        public void Do() { }
    }
}

namespace patterns.Layers.FeatureC.Dal
{
    public class Dal_C : IDal
    {
        public void Get() { }
    }
}