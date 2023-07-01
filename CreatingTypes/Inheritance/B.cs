namespace Inheritance
{
    public class B : A
    {
        // public int Counter = 1;

        //The new modifier communicates your intent to the compiler—and other
        // programmers—that the duplicate member is not an accident.
        public new int Counter = 2;

        // Overloading and Resolution
        static void Foo(Asset a) { }
        static void Foo(House h) { }

    }
}