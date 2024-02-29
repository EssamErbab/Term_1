using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5ErbabENetsereabM
{
    internal class Employee
    {
        public string employeeID;
        public string employeeFirstName;
        public string employeeLastName;
        public int employeeMonthlySalary;

        public Employee(string ID, string firstName, string lastName, int monthlySalary)
        {
            employeeID = ID;
            employeeFirstName = firstName;
            employeeLastName = lastName;
            employeeMonthlySalary = monthlySalary;
        }
        public void ChangeFirstName(string newName)
        {
            employeeFirstName = newName;
        }
        public void ChangeLastName(string newName) 
        { 
            employeeLastName = newName;
        }
        public void ChangeSalary(int newSalary)
        {
            employeeMonthlySalary = newSalary;
        }
    }
}
