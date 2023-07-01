using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Delegates
{
    public delegate void ProgressReporter(int percentComplete);
    public class MyReporter
    {
        public string Prefix = "";
        public void ReportProgress(int percentComplete) => Console.WriteLine(Prefix + percentComplete);
    }
}