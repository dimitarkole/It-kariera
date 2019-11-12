using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class BaseEmployee
    {
        private string employeeID;
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private string employeeName;
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        private string employeeAddress;

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.EmployeeAddress = employeeAddress;
        }

        public string EmployeeAddress
        {
            get { return employeeAddress; }
            set { employeeAddress = value; }
        }

        public virtual void Show()
        {
            Console.WriteLine($"{this.EmployeeID}");
            Console.WriteLine($"{this.EmployeeName}");
            Console.WriteLine($"{this.EmployeeAddress}");

        }

        public abstract double CalculateSalary(int workingHours);

        public abstract string GetDepartment();


    }
}
