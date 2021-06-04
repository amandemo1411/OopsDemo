using OopsDemo.Abstract;
using OopsDemo.Constructors;
using System;

namespace OopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConstructorExample constructorExample = new ConstructorExample(); // Default constructor
            //ConstructorExample constructorExample = new ConstructorExample(1, 5); // Parameterized constructor

            ConstructorExample example = new ConstructorExample(1, 5);
           
            
            
            ConstructorExample example1 = new ConstructorExample(example);// Copy construtor

            //ConstructorExample newConstructorExample = new ConstructorExample(); // static constructor


            example.PrintConstructorExample();
        }
    }
}
