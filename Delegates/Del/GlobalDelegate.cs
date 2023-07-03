namespace Delegates.Del
{
    public delegate int Transformer(int x);// create a new transformer delegate
    public delegate T Transformer1<T>(T x);// create a new transformer delegate
    public delegate void ProgressReporter(int percentComplete); // progress reporter delegate

    public delegate object ObjectRetriever();
    public delegate void StringAction(string s);
    public delegate bool PredicateDel<in T>(T obj);
}