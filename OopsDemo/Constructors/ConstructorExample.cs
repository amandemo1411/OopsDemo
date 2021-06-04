﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OopsDemo.Constructors
{
    public class ConstructorExample
    {
         int a;
         int b;
        int copya1;
        int copyb1;
        //public ConstructorExample() // default constructor
        //{
        //    a = 10;
        //    b = 5;            
        //}

        //static ConstructorExample() // static constructor
        //{
        //    a = 10;
        //    b = 5;
        //}

        public ConstructorExample(int x, int y) // parameterized constructor
        {
            this.a = x;
            this.b = y;
        }

        public ConstructorExample(ConstructorExample constructor) // copy constructor
        {
            copya1 = constructor.a;
            copyb1 = constructor.b;
        }

        public void PrintConstructorExample()
        {
            Console.WriteLine("Value of a: " + copya1);
            Console.WriteLine("Value of b: " + copyb1);
        }
    }
}
