namespace TypeBasics
{

    public class ConversionType
    {

        public void ConvertToType()
        {
            int x = 12345; // int is a 32-bit integer
            long y = x; // Implicit conversion to 64-bit integer
            short z = (short)x; // Explicit conversion to 16-bit integer
        }

    }
}