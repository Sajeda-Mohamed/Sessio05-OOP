using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_OverLoading
{
    internal class Employee
    {
        #region Auto Prop
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Password { get; set; }
        public string SecurityStamp { get; set; }
        #endregion

        #region Methods
        public static explicit operator EmployeeViewModel(Employee employee)
        {
            string[] Names = employee.Name.Split(' ');
            return new EmployeeViewModel()
            {
                FName = Names[0],
                LName = Names[1],
            };
        }
        #endregion
    }
}
