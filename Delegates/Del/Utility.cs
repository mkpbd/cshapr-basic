using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates.Del
{
    public class Utility
    {
        public void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
        public int Square(int x) => x * x;
        public int Cube(int x) => x * x * x;

        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10); // Invoke delegate
                System.Threading.Thread.Sleep(100); // Simulate hard work
            }
        }
        public void WriteProgressToConsole(int percentComplete) => Console.WriteLine(percentComplete);
        public void WriteProgressToFile(int percentComplete) => System.IO.File.WriteAllText("progress.txt",
            percentComplete.ToString());
    }
}