using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial_Classes
{
    internal partial class Employee
    {
        #region Auto Prop
        public decimal Salary { get; set; }
        #endregion

        #region Methods
        public void Print ()
        {
            Console.WriteLine("Hello from Partial Class");
        }
        #endregion
    }
}
