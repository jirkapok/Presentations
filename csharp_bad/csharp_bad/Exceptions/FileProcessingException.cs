using System;

namespace csharp_bad.Exceptions
{
    public class FileProcessingException : Exception
    {
        public ErrorCodes ErrorCode { get; }

        public FileProcessingException(string message, ErrorCodes errorCode) : base(message)
        {
            this.ErrorCode = errorCode;
        }
    }
}