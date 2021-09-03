using System;

namespace CSharpSample
{
    internal sealed class A
    {
        public bool Value;
    }

    internal sealed class B
    {
        public A Data;
    }

    class Program
    {
        static void Main(string[] _)
        {
            var b = new B();

            if (b?.Data?.Value != false)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}