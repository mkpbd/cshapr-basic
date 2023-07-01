using ImplementInterface;
namespace Helper
{
    public static class Util
    {
        public static object GetCountDown() => new Countdown();

        static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        static void Initialize<T>(T[] array) where T : new()
        {
            for (int i = 0; i < array.Length; i++) array[i] = new T();
        }
    }
}