namespace CreatingTypes.Enums
{
    [Flags]
    public enum BorderSides2
    {
        None = 0,
        Left = 1,
        Right = 2,
        Top = 4,
        Bottom = 8
    }

    enum BorderSides3
    {
        None = 0,
        Left = 1,
        Right = 1 << 1,
        Top = 1 << 2,
        Bottom = 1 << 3
    }
}