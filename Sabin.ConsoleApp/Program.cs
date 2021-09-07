using System;
using System.Collections.Generic;
using System.Collections;

namespace Test
{
    internal class MyClass
    {
        private static void Testing()
        {
        }
    }

    internal class MyClass2
    {
        private class TestClass
        {
        }

        private static void Testing()
        {
        }
    }
}

namespace Sabin.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
            Test();
            Test();
            Console.ReadLine();
        }

        private static int i = 10; //variable
        private const float pi = 3.1415f; //constant

        private static void Test()
        {
            char ch = 'C';
            string s = "this is me";
            int i = 1;
            decimal d = 1.2m;
            double dbl = 1.2d;
            float f = 1.2f;
            bool b = false;

            Console.WriteLine("I am from Test Function");
        }
    }
}