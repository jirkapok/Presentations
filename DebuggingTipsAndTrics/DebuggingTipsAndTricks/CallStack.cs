using System.Threading;
using DebuggingTipsAndTricks;

/// <summary>
/// 1. Change breakpoint location: Right click on breakpoint > Condition > location
/// 2. Debug multiple processes: right on project: Debug - Start new instance
/// 2.a. Menu Debug > Detach all
/// 2.b. Find the process in Process explorer in Details: we need process ids
/// 2.c. Menu: Debug > Attach to process, sort by PID (Show processes from all users)
/// 2.d. Menu: Debug > Windows > Threads > right click switch to thread
/// </summary>
internal static class CallStack
{
    internal static void FirstCall()
    {
        // access private field from watch window: dataitems.items[0].privateKey
        // otherwise privateKey is not visible in debugging.
        var dataitems = new DataItemCollection();

        StartNeverEndingThread("ThreadA");
        StartNeverEndingThread("ThreadB");
    }

    private static void StartNeverEndingThread(string threadName)
    {
        var threadA = new Thread(SecondCall);
        threadA.Name = threadName;
        threadA.Start();
    }

    private static void SecondCall()
    {
        WhileCycle();
    }

    private static void WhileCycle()
    {
        while (true)
        {
            Thread.Sleep(1000);
            int a = 1;
            Thread.Sleep(1000);
            a = 2;
            Thread.Sleep(1000);
            a = 3;
        }
    }
}