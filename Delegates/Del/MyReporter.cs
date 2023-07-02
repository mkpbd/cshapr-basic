using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates.Del
{
    public class MyReporter
    {
        public string Prefix = "";
        public void ReportProgress(int percentComplete) => Console.WriteLine(Prefix + percentComplete);
    }
}
