﻿namespace Playground2.Behavioral.Visitor.EmployeesDemo.Employees
{
    using System;

    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    public class VacationVisitor : IVisitor
    {
        public void Visit(Employee employee)
        {
            if (employee != null)
            {
                // Provide 3 extra vacation days
                // The number of vacation days may be given as a constructor parameter
                employee.VacationDays += 3;
                Console.WriteLine(
                    "{0} {1}'s new vacation days: {2}",
                    employee.GetType().Name,
                    employee.Name,
                    employee.VacationDays);
            }
        }
    }
}
