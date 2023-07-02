namespace Delegates.Del
{
    public delegate int Transformer(int x);// create a new transformer delegate
    public delegate T Transformer1<T>(T x);// create a new transformer delegate
    public delegate void ProgressReporter(int percentComplete); // progress reporter delegate
}