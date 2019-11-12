using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            task3();

        }

        static void task3()
        {
            double length, width, height;
            length = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            Box myBox = new Box(length,width,height);
            myBox.SurfaceArea();
            myBox.LateralSurfaceArea();
            myBox.Volume();
        }


        static void task2()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person2>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person2(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));

        }

        static void task1()
        {
            Dictionary<string, List<Employee>> allEmployees = new Dictionary<string, List<Employee>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i<n; i++)
            {
                string[] personData = Console.ReadLine().Split(' ');
                string name = personData[0];
                double salary = double.Parse(personData[1]);
                string position = personData[2];
                string department = personData[3];

                Employee employee;

                if (personData.Length == 4)
                {
                    employee = new Employee(name, salary, position, department);
                }
                else if (personData.Length==5)
                {
                    try
                    {
                        employee = new Employee(name, salary, position, department, int.Parse(personData[4]));
                    }
                    catch (Exception)
                    {
                        employee = new Employee(name, salary, position, department, personData[4]);
                    } 
                }                    
                else employee = new Employee(name, salary, position, department, personData[4], int.Parse(personData[5]));

                if (allEmployees.ContainsKey(department))
                {
                    allEmployees[department].Add(employee);
                }
                else
                {
                    List<Employee> employees = new List<Employee>();
                    employees.Add(employee);
                    allEmployees.Add(department, employees);
                }
            }

            Dictionary<string, double> departmentWithAverageSalary = new Dictionary<string, double>();
            foreach (var department in allEmployees)
            {
                double averageSalerys = department.Value.Average(x => x.Salary);
                departmentWithAverageSalary.Add(department.Key, averageSalerys);
            }

            double maxAverageSalary = departmentWithAverageSalary.Values.Max();
            string maxAverageSalaryDepartament = departmentWithAverageSalary.Where(kvp => kvp.Value == maxAverageSalary).Select(kvp => kvp.Key).First();
            Console.WriteLine($"Highest Average Salary: {maxAverageSalaryDepartament}");
            List<Employee> employeesInDepartment = allEmployees[maxAverageSalaryDepartament];
            employeesInDepartment= employeesInDepartment.OrderByDescending(x => x.Salary).ToList();
            foreach (Employee employee in employeesInDepartment)
            {
                employee.Print();
            }
        }
    }
}