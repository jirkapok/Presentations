using System;
using System.Diagnostics;

namespace DebuggingTipsAndTricks
{
    class Program
    {
        /// <summary>
        /// 1. What are the project.vshost.exe processes?
        /// Visual studio hosting process: https://msdn.microsoft.com/en-us/library/ms242202.aspx
        /// Enable startup arguments in project properties.
        /// Task manager/Process Explorer: Right click on Columns > select columns - PID, command line.
        /// 
        /// 2. How do i debug application without source code and pdb?
        /// Menu tools > Options > Debugging > Symbols
        /// dotPeek> Tools > Symbol server
        /// Debug Windows > Modules
        /// 
        /// 3. Remote debugger
        /// https://msdn.microsoft.com/en-us/library/y7f5zaaa.aspx?f=255&MSPPError=-2147217396
        /// 
        /// 4. Fuslogvw.exe (Assembly Binding Log Viewer)
        /// https://msdn.microsoft.com/en-us/library/e74a18c4(v=vs.110).aspx
        /// From developer command prompt as administrator: fuslogvw
        /// Setttings: Log bind failures to disk, Enable Custom log path (full path to the directory)
        ///  </summary>
        static void Main(string[] args)
        {
            // https://msdn.microsoft.com/en-us/library/cktt23yw.aspx
            //  Debugger.Launch();
            // F5, F10, F11, F9

            string arguments = string.Join(" ", args); Console.WriteLine("");
            Console.WriteLine("sdfasd");
            Console.WriteLine("Startup arguments: '{0}'", arguments);
            var pid = Process.GetCurrentProcess().Id;
            Console.WriteLine("Process ID: {0}", pid);

            //ExternalLogging.Log("Put it to the log...");

            CallStack.FirstCall();

            Console.ReadKey();
        }
    }
}
