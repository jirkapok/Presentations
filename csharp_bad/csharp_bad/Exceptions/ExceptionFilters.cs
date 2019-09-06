using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace csharp_bad.Exceptions
{
    public class ExceptionFilters
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string Fail(int fileId)
        {
            try
            {
                ProcessFile(fileId);
                return string.Empty;
            }
            catch (FileProcessingException e) when (e.ErrorCode == ErrorCodes.NotEnoughSpace)
            {
                return "NotEnoughSpace";
            }
            catch (FileProcessingException e) when (e.ErrorCode == ErrorCodes.FileTooLarge)
            {
                return "FileTooLarge";
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string ReportFailed(int fileId)
        {
            try
            {
                ReportFailedNested(fileId);
                return string.Empty;
            }
            catch (Exception e)
            {
                return e.Data["stack"].ToString();
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ReportFailedNested(int fileId)
        {
            try
            {
                ProcessFile(fileId);
            }
            // catch blocks order matters
            catch (FileProcessingException e) when (e.ErrorCode == ErrorCodes.FileTooLarge)
            {
                DumpStackFrames(e); // entered catch block
                throw;
            }
            catch (FileProcessingException e) when (DumpStackFrames(e)) // not entered catch
            {
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static bool DumpStackFrames(Exception e)
        {
            // e.StackTrace is identical, we search for stack not "stack trace"
            // stack affects performance and crash dumps
            var stack = new StackTrace().ToString();
            e.Data["stack"] = stack;
            Console.WriteLine(stack);
            return false;
        }


        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void ProcessFile(int fileId)
        {
            var dummy = DateTime.UtcNow; // dummy variable on the stack

            if (fileId > 0)
                throw new FileProcessingException("Dummy", ErrorCodes.NotEnoughSpace);

            if (fileId == 0)
                throw new FileProcessingException("Dummy", ErrorCodes.FileTooLarge);

            throw new Exception();
        }
    }
}