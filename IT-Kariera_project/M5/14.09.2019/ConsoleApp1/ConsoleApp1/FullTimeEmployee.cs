using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;

        public string EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }

        private string employeeDepartment;



        public override void Show()
        {
            base.Show();
            Console.WriteLine(this.EmployeeDepartment);
            Console.WriteLine(this.EmployeePosition);

        }

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress,
            string employeePosition, string employeeDepartment)
            : base(employeeID, employeeName, employeeAddress)
        {
            this.EmployeeDepartment = employeeDepartment;
            this.EmployeePosition = employeePosition;

        }

        

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.8;
        }

        public override string GetDepartment()
        {
            return this.EmployeeDepartment;
        }
    }
}
