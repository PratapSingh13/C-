// Introducing Namespace in C#
using System;
namespace myNamespace
{
    public class Hello
    {
        public static void myMethod()
        {
            Console.WriteLine("Creating my Namespace");
        }
    }
}

namespace myProgram
{
    public class MyClass
    {
        public static void Main()
        {
            myNamespace.Hello.myMethod();
        }
    }
}
