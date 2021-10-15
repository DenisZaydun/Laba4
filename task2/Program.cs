using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            A mainAAA = new A(new C(){Text = "Lalalal"}, new D(), new E());

            mainAAA.PrintPropertiesToDebug();

            Console.ReadLine();
        }
    }
}
