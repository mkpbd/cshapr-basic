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

        public static void Transform1<T>(T[] values, Transformer1<T> t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }

        public static void Transform3<T>(T[] values, Func<T, T> transformer)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = transformer(values[i]);
        }

        public string RetriveString() => "hello";
        public void ActOnObject(object o) => Console.WriteLine(o); // hello

        public static int GetIndexOfFirstNonEmptyBin(int[] bins) =>
                            Array.FindIndex(bins, IsGreaterThanZero);
        public static bool IsGreaterThanZero(int value) => value > 0;
        public static bool IsLessThanZero(int value) => value < 0;

        public static void CallMeRightBack(Predicate<int> userCallback)
        {
            bool result = userCallback(42);
            Console.WriteLine(result);
        }

        public static bool IsLongString(object o)
        {
            return o is string s && s.Length > 20;
        }
    }
}