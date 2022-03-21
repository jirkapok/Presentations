using log4net;

namespace DebuggingTipsAndTricks
{
    internal class ExternalLogging
    {
        public static void Log(string message)
        {
            // The assembly is not available for .net core
            var log = LogManager.GetLogger(typeof(ExternalLogging));
            log.Info(message);
        }
    }
}
