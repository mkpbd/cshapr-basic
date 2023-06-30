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


        public void PredefinedTypes()
        {
            /**
                Numeric
                    — —Signed integer (sbyte, short, int, long)
                    — —Unsigned integer (byte, ushort, uint, ulong)
                    — —Real number (float, double, decimal)

                Logical (bool)
                Character (char)

            Reference  Type
                String (string)
                Object (object)

            */

            int i = 5;
            System.Int32 i1 = 5;
            // Underlying hexadecimal representation
            int i2 = 7; // 0x7
            bool b = true; // 0x1
            char c = 'A'; // 0x41
            float f = 0.5f; // uses IEEE floating-point encoding

            Console.WriteLine(1.0.GetType()); // Double (double)
            Console.WriteLine(1E06.GetType()); // Double (double)
            Console.WriteLine(1.GetType()); // Int32 (int)
            Console.WriteLine(0xF0000000.GetType()); // UInt32 (uint)
            Console.WriteLine(0x100000000.GetType()); // Int64 (long)
        }


        public void BooleanTypeConversion()
        {
            /*
            == and != test for equality and inequality of any type but always return a bool value.
            Value types typically have a very simple notion of equality


            */
            int x = 1;
            int y = 2;
            int z = 1;
            Console.WriteLine(x == y); // False
            Console.WriteLine(x == z); // True
            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            Console.WriteLine(d1 == d2); // False
            Dude d3 = d1;
            Console.WriteLine(d1 == d3); // True
        }


        public void CharConversions()
        {
            char copyrightSymbol = '\u00A9';
            char omegaSymbol = '\u03A9';
            char newLine = '\u000A';


        }

        public void StringType()
        {
            string a = "test";
            string b = "test";
            Console.Write(a == b); // True
            string at = "Here's a tab:\t";

            string a1 = "\\\\server\\fileshare\\helloworld.cs";

            /*

            allows verbatim string literals. A verbatim string literal is prefixed with @ and does not support escape sequences

        */
            string a2 = @"\\server\fileshare\helloworld.cs";
            //A verbatim string literal can also span multiple lines:
            string escaped = "First Line\r\nSecond Line";
            string verbatim = @"First Line 


                Second Line";
            // True if your text editor uses CR-LF line separators:
            Console.WriteLine(escaped == verbatim);

            string xml = @"<customer id=""123""></customer>";

            //============ String concatenation============

            //The + operator concatenates two strings:
            string s = "a" + "b";
            //String interpolation  use $ operator
            int x = 4;
            Console.Write($"A square has {x} sides"); // Prints: A square has 4 sides

            string s1 = $"255 in hex is {byte.MaxValue:X2}"; // X2 = 2-digit hexadecimal
                                                             // Evaluates to "255 in hex is FF"
            bool b2 = true;
            Console.WriteLine($"The answer in binary is {(b2 ? 1 : 0)}");

            /**
                Should you need to use a colon for another purpose (such as a ternary
                conditional operator, which we’ll cover later), you must wrap the entire
                expression in parentheses:


            */
            const string greeting = "Hello";
            const string message = $"{greeting}, world";

        }

    }
}