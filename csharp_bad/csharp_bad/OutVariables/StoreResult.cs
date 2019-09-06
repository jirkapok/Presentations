using System;

namespace csharp_bad.OutVariables
{
    public class StoreResult
    {
        public bool Passed { get; private set; }
        public string ErrorMessage { get; private set; }

        // to prevent creation somewhere else
        private StoreResult()
        {
        }

        public static StoreResult Ok = new StoreResult
        {
            ErrorMessage = String.Empty,
            Passed = true
        };

        public static StoreResult CreateFailed(string errorMessage)
        {
            return new StoreResult
            {
                ErrorMessage = errorMessage,
                Passed = false
            };
        }
    }
}