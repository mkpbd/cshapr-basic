namespace TypeBasics
{

    public class UnitConverter
    {
        int ratio; // Field
        public UnitConverter(int unitRatio) // Constructor
        {
            ratio = unitRatio;
        }
        public int Convert(int unit) // Method
        {
            return unit * ratio;
        }

    }
}