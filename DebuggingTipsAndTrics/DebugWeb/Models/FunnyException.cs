using System;

namespace DebugWeb.Models
{
    public class FunnyException : ApplicationException
    {
        public FunnyException(string message): base(message)
        {
        }
    }
}