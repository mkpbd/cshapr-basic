namespace TypeBasics
{
    public class BasicTypes
    {

        int x = 12 * 30;
        // Console.WriteLine (x);
        const int y = 360;
        // Predefined Type Examples
        int xx = 10;

        public void PredefinedType()
        {
            string message = "Hello world";
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage); // HELLO WORLD
            int xxx = 100;

            message = message + xxx.ToString();
            Console.WriteLine(message); // Hello world2022
        }

    }
}