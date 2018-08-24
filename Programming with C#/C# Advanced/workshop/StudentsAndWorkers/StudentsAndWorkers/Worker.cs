namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private float weekSalary;
        private float workHoursPerHour;

        public Worker(string firstName, string lastName, float weekSalary, float workHoursPerHour) : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerHour = workHoursPerHour;
        }

        public float WeekSalary { get => this.weekSalary; set => this.weekSalary = value; }

        public float WorkHoursPerHour { get => this.workHoursPerHour; set => this.workHoursPerHour = value; }

        public float MoneyPerHour()
        {
            return weekSalary / workHoursPerHour;
        }
    }
}
