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
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; } 
        #endregion
    }
}
