using AdvanceCshapr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Classes
{
    public class Foo : IFoo
    {
        public static event EventHandler<EventArgs> StaticEvent;

        public virtual event EventHandler<EventArgs> VirtualEvent;

        public event EventHandler ev;

        event EventHandler IFoo.Ev
        {
            add { ev += value; }
            remove { ev -= value; }
        }

        Func<int, int> sqr = x => x * x;

        Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
        //  int total = totalLength("hello", "world"); // total is 10;

        Func<string> greetor = () => "Hello, world";
        Func<string> Greeter = () => "Hello, world";

        void Foos<T>(T x) { }
        void Bar<T>(Action<T> a)
        {

        }
        //void  Barr<T>(x => Foo(x)); // Specify type parameter for Bar
        //void   Barrr<T>(Foo); // As above, but with method group

        public int Sqr(int x) => x * x;
        static int factor = 2;
        Func<int, int> multiplier = n => n * factor;

        static int seed = 0;
        Func<int> natural = () => seed++;

        static Func<int> Natural()
        {
            int seed = 0;
            return () => seed++; // Returns a closure
        }

        public event EventHandler Clicked = delegate { };

        void ReadFile()
        {
            StreamReader reader = null; // In System.IO namespace
            try
            {
                reader = File.OpenText("file.txt");
                if (reader.EndOfStream) return;
                Console.WriteLine(reader.ReadToEnd());
            }
            finally
            {
                if (reader != null) reader.Dispose();
            }
        }


        void Display(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            Console.WriteLine(name);
        }



    }

    public struct Nullable<T> where T : struct
    {
        public T Value { get; }
        public bool HasValue { get; }
        public T GetValueOrDefault() { return Value; }
        public T GetValueOrDefault(T defaultValue){ return defaultValue; }

    }
}
