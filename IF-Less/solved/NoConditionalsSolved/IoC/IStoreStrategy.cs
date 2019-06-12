namespace NoConditionalsSolved.IoC
{
    internal interface IStoreStrategy
    {
        IStore GetStore(string storeId);
    }
}