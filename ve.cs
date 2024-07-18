using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<IEmployee> Employees = new List<IEmployee>
        {
            new Employee("John Doe", 1),
            new Employee("Jane Smith", 2),
            new Employee("Alice Johnson", 3)
        };

        string employeeFullName = "Jane Smith";

        IEmployee employee = Employees.First(e => e.FullName.Equals(employeeFullName));

        if (employee != null)
        {
            Console.WriteLine($"Found employee: {employee.FullName} with ID: {employee.Id}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
