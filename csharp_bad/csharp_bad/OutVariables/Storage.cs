namespace csharp_bad.OutVariables
{
    public class Storage
    {
        public static bool Store(int input, out string errorMessage)
        {
            if (input > 5)
            {
                errorMessage = "out of scope";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public static StoreResult Store(int input)
        {
            if (input > 5)
                return StoreResult.CreateFailed("out of scope");

            return StoreResult.Ok;
        }
    }
}