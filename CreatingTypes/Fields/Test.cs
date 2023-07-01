namespace Fields
{
    public class Test
    {
        public const decimal ProgramVersion = 2.3M;
        static readonly DateTime StartupTime = DateTime.Now;
        const double twoPI = 2 * System.Math.PI;

        public static double Circumference(double radius)
        {
            return 2 * System.Math.PI * radius;
        }
    }

}