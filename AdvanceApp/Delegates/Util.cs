using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Delegates
{
    public delegate void ProgressReporterMultiCast(int percentComplete);
    public class Util
    {
        public static void HardWork(ProgressReporterMultiCast p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10); // Invoke delegate
                System.Threading.Thread.Sleep(100); // Simulate hard work
            }
        }
    }
}