using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ContractEmployee :BaseEmployee
    {

        private string employeeTask;

        public string EmployeeTask
        {
            get { return employeeTask; }
            set { employeeTask = value; }
        }

        private string employeeDepartment;

        public ContractEmployee(string EmployeeTask, string employeeDepartment, string employeeID, string employeeName, string employeeAddress) 
            : base(employeeID, employeeName, employeeAddress)
        {
            this.EmployeeTask = employeeTask;
            this.EmployeeDepartment = employeeDepartment;

        }

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(this.EmployeeTask);
            Console.WriteLine(this.employeeDepartment);
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return this.EmployeeDepartment;
        }
    }
}
