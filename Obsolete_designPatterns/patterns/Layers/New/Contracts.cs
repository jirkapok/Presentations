// Simplified by defining only one interface for all feature services
// i.e. there should be IViewFeatureA, IViewFeatureB etc.
namespace patterns.Layers.New.Contracts.UI
{
    // View and Bl in the same namespace: view defines it self, and BL requirements
    public interface IView
    {
        void View();
    }

    public interface IBL
    {
        void Do();
    }
}

// Interface is defined by the consumer, i.e. BL defines, which Dal services it needs
namespace patterns.Layers.New.Contracts.BL
{
    public interface IDal
    {
        void Get();
    }
}