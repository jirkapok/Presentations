// Each layer declares it own interfaces

namespace patterns.Layers.Old.UI
{
    public interface IUI
    {
        void ViewA() { }
        void ViewB() { }
        void ViewC() { }
    }
}

namespace patterns.Layers.Old.BL
{
    public interface IBL
    {
        void DoA() { }
        void DoB() { }
        void DoC() { }
    }
}

namespace patterns.Layers.Old.Dal
{
    public interface IDal
    {
        void GetA() { }
        void GetB() { }
        void GetC() { }
    }
}