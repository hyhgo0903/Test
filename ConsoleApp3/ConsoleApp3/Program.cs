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
            throw new Exception();
        }
    }
}