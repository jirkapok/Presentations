namespace Calculator
{
    internal interface IUserInterface
    {
        void WriteResult(int result);
        Commands ReadCommand();
        int ReadNumber();
    }
}