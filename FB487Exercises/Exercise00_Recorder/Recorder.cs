using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise00_Recorder
{
    public class Recorder
    {
        static private long bytesPhysicalBefore = 0;
        static private long bytesVirtualBefore = 0;
        static private Stopwatch timer = new Stopwatch();

        public static void Start()
        {

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            bytesPhysicalBefore = Process.GetCurrentProcess().WorkingSet64;
            bytesVirtualBefore = Process.GetCurrentProcess().VirtualMemorySize64;

            timer.Restart();
        }

        public static Recording Stop(bool outputToConsole = false)
        {
            timer.Stop();

            long bytesPhysicalAfter = Process.GetCurrentProcess().WorkingSet64;
            long bytesVirtualAfter = Process.GetCurrentProcess().VirtualMemorySize64;

            var recording = new Recording
            {
                PhysicalBytesUsed = bytesPhysicalAfter - bytesPhysicalBefore,
                VirtualBytesUsed = bytesVirtualAfter - bytesVirtualBefore,
                MillisecondsElapsed = timer.ElapsedMilliseconds
            };

            if (outputToConsole)
            {
                Console.WriteLine("{0:N0} physical bytes used.", recording.PhysicalBytesUsed);
                Console.WriteLine("{0:N0} virtual bytes used.", recording.VirtualBytesUsed);
                Console.WriteLine("{0:N0} milliseconds elapsed.", recording.MillisecondsElapsed);
            }
            return recording;
        }
    }

    public class Recording
    {
        public long PhysicalBytesUsed { get; set; }
        public long VirtualBytesUsed { get; set; }
        public long MillisecondsElapsed { get; set; }
    }
}
