using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Department
    {
        public string Department_Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int Budget { get; set; }
        public Employee[] Employees;
        public int RequiredExperience { get; set; }
        public bool IsBachelorDegreeRequired { get; set; }
        public Department()
        {
            Employees = new Employee[0];
        }
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }
        public void SalaryAverageOfDepartment()
        {
            int sum = 0;
            sum = Budget / Employees.Length;
            Console.WriteLine(sum);
        }
        public void CancelEmployee(Employee rejectedemployer)
        {
            for(int i = 0; i < Employees.Length; i++)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = rejectedemployer;
            }
        }
        
    }
}

