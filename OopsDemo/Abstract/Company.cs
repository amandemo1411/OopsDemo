using System;
using System.Collections.Generic;
using System.Text;

namespace OopsDemo.Abstract
{
    public abstract class Company : IEmployeeServices
    {
        public abstract void CompanyDetails();

        public void CreateSortedListExample()
        {
            Console.WriteLine("Sorting example is here");
        }

        public void OfficeTiming()
        {
            Console.WriteLine("Office timing is 9 - 6");
        }
    }

    public class Employee : Company
    {
        public override void CompanyDetails()
        {
            throw new NotImplementedException();
        }
    }
}
