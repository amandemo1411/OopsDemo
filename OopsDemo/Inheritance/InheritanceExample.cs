using System;
using System.Collections.Generic;
using System.Text;

namespace OopsDemo
{
    public class InheritanceExample
    {
        public void GetDetails()
        {
            ChildA obj = new ChildA();
            obj.GetChildDetails();

            ChildB obj1 = new ChildB();
            obj1.GetChildDetails();
        }
    }

    public class ParentA
    {
        public void GetHouseDetails()
        {
            Console.WriteLine("Printing house details");
        }

        public void GetCarDetails()
        {
            Console.WriteLine("Printing car details");
        }
    }

    public class ChildA : ParentA
    {
        public void GetChildDetails()
        {
            Console.WriteLine("Printing child A details");
        }
    }

    public class ChildB : ParentA
    {
        public void GetChildDetails()
        {
            Console.WriteLine("Printing child B details");
        }
    }
}
