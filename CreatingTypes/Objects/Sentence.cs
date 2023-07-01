namespace Objects
{
    public class Sentence
    {
        string[] words = "The quick brown fox".Split();
        public string this[int wordNum] // indexer
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }

        public void UnderStandingIndexer()
        {
            string s = "hello";
            Console.WriteLine(s[0]); // 'h'
            Console.WriteLine(s[3]); // 'l'
        }
    }
}