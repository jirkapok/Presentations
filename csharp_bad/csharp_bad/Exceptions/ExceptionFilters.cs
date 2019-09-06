using System;

namespace csharp_bad.Exceptions
{
    public class ExceptionFilters
    {
        public static string Fail(int fileId)
        {
            try
            {
                ProcessFile(fileId);
                return string.Empty;
            }
            catch (FileProcessingException e) when(e.ErrorCode == ErrorCodes.NotEnoughSpace)
            {
                return "NotEnoughSpace";
            }
            catch (FileProcessingException e) when (e.ErrorCode == ErrorCodes.FileTooLarge)
            {
                return "FileTooLarge";
            }
        }

        private static void ProcessFile(int fileId)
        {
            if (fileId > 0)
                throw new FileProcessingException("Dummy", ErrorCodes.NotEnoughSpace);

            if (fileId == 0)
                throw new FileProcessingException("Dummy", ErrorCodes.NotEnoughSpace);

            throw new Exception();
        }
    }
}