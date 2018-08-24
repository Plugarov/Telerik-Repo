namespace Playground2.Behavioral.Visitor.EmployeesDemo
{
    using Playground2.Behavioral.Visitor.EmployeesDemo.Employees;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    internal class EmployeesList
    {
        private readonly List<Employee> employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            this.employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            this.employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var employee in this.employees)
            {
                employee.Accept(visitor);
            }

            Console.WriteLine();
        }
    }
}
