namespace Objects
{
    public class Note
    {
        // These init-only properties act like read-only properties, except that they can
        //also be set via an object initializer:
        public int Pitch { get; init; } = 20; // “Init-only” property
        public int Duration { get; init; } = 100; // “Init-only” property
        readonly int _pitch;
        public int Pitch2 { get => _pitch; init => _pitch = value; }

        public Note(int pitch = 20, int duration = 100)
        {
            Pitch = pitch; Duration = duration;
        }
    }
}