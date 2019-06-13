namespace Calculator
{
    public interface IUserInterface
    {
        void WriteResult(int result);
        Commands ReadCommand();
        int ReadNumber();
    }
}