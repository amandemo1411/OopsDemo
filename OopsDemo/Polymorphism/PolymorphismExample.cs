using System;
using System.Collections.Generic;
using System.Text;

namespace OopsDemo
{
    public class ProcessData
    {
        public void ProcessSum(int a, int b)
        {
            ProcessWork(a, 10, "sum");
        }

        public void ProcessMul(int a, int b)
        {
            ProcessWork(a, 10, "mul");
        }

        public void ProcessWork(int a, int b, string value)
        {
            int c = 0;
            if (value == "sum")
                c = a + b;
            else if (value == "mul")
                c = a * b;
            else
                c = 100;
            Console.WriteLine("Value of C is " + c);
        }
    }
}
