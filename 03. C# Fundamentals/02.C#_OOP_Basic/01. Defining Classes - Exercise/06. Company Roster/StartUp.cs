using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            var departmentsAverageSalary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < number; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();

                AddingNewEmployee(tokens, employees, departmentsAverageSalary);
            }

            var highestAverageSalary = departmentsAverageSalary.OrderByDescending(d => d.Value.Average()).First();
            var department = highestAverageSalary.Key;
            var departmentEmployees = employees.Where(e => e.Department == department)
                .OrderByDescending(s => s.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {department}");
            foreach (var employee in departmentEmployees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }

        private static void AddingNewEmployee(string[] tokens, List<Employee> employees, Dictionary<string, List<decimal>> deparmtmentsAverageSalary)
        {
            var name = tokens[0];
            var salary = decimal.Parse(tokens[1]);
            var position = tokens[2];
            var department = tokens[3];

            var newEmployee = new Employee(name, salary, position, department);

            if (!deparmtmentsAverageSalary.ContainsKey(department))
            {
                deparmtmentsAverageSalary[department] = new List<decimal>();
            }

            deparmtmentsAverageSalary[department].Add(salary);

            if (tokens.Length > 4)
            {
                if (tokens.Length == 5)
                {
                    var age = 0;
                    var isAge = int.TryParse(tokens[4], out age);

                    if (isAge)
                    {
                        newEmployee.Age = age;
                    }
                    else
                    {
                        newEmployee.Email = tokens[4];
                    }
                }
                else
                {
                    newEmployee.Age = int.Parse(tokens[5]);
                    newEmployee.Email = tokens[4];
                }
            }

            employees.Add(newEmployee); 
        }
    }
}
