namespace Method
{
    public class MethodAbout
    {
        int Foo(int x) { return x * 2; }
        //Expression-bodied methods
        int Foo1(int x) => x * 2;
        // Expression-bodied functions can also have a void return type:
        void Foo2(int x) => Console.WriteLine(x);

        // Local methods
        // You can define a method within another method:
        void WriteCubes()
        {
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
            Console.WriteLine(Cube(5));
            int Cube(int value) => value * value * value;
        }

        //Overloading methods
        void Foo4(int x) { }
        void Foo4(double x) { }
        void Foo4(int x, float y) { }
        void Foo4(float x, int y) { }

        /**
However, the following pairs of methods cannot coexist in the same type,
because the return type and the params modifier are not part of a method’s signature

        */

    }
}