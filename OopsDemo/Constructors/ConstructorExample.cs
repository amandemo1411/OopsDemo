using System;
using System.Collections.Generic;
using System.Text;

namespace OopsDemo.Constructors
{
    public class ConstructorExample
    {
        static int a;
        static int b;
        public ConstructorExample() // default constructor
        {
            a = 10;
            b = 5;
        }

        //static ConstructorExample() // static constructor
        //{
        //    a = 10;
        //    b = 5;
        //}

        //public ConstructorExample(int x, int y) // parameterized constructor
        //{
        //    this.a = x;
        //    this.b = y;
        //}

        //public ConstructorExample(ConstructorExample constructor) // copy constructor
        //{
        //    a = constructor.a;
        //    b = constructor.b;
        //}

        public void PrintConstructorExample()
        {
            Console.WriteLine("Value of a: " + a);
            Console.WriteLine("Value of b: " + b);
        }
    }
}
