using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed_Classes
{
    internal class Parent
    {
        #region Prop
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        #endregion

        #region Methods
        public virtual void Print()
        {
            Console.WriteLine("Hello from Parent");
        }
        #endregion
    }
    internal class Child:Parent
    {
        #region Prop
        public override int Salary
        { get => base.Salary; set => base.Salary = value + 1500; } 
        #endregion

        #region Methods
        public sealed override void Print()
        {
            Console.WriteLine("Hello from Child");
        }
        #endregion
    }
    internal sealed class GrandChild:Child
    {
        #region Methods
        //public override void Print()
        //{
        //    Console.WriteLine("Hello from Grand Child");
        //}
        #endregion
    }
}
