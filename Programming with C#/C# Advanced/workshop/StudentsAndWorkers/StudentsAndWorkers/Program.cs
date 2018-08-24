namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Gosho", "Vaptsarov", 5.2));
            students.Add(new Student("Penko", "Vazov", 5.4));
            students.Add(new Student("Ivo", "Karamazov", 5.2));
            students.Add(new Student("Stamat", "Petrov", 3.4));
            students.Add(new Student("Alex", "Cuklev", 3.4));
            students.Add(new Student("Iva", "Georgiev", 5.3));
            students.Add(new Student("Tanya", "Petrov", 2.4));
            students.Add(new Student("Gosho", "Ivanov", 2.9));

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Penko", "Vazov", 40, 8));
            workers.Add(new Worker("Ivo", "Karamazov", 35, 11));
            workers.Add(new Worker("Stamat", "Petrov", 15, 20));
            workers.Add(new Worker("Gosho", "Vaptsarov", 30, 10));
            workers.Add(new Worker("Gosho", "Vaptsarov", 20, 6));

            var sortByAscGrade = students
                .OrderByDescending(x => x.Grade)
                .Select(x => x.LastName)
                .ToList();

            var sortByMoneyPerHour = workers
                .OrderByDescending(x => x.MoneyPerHour())
                .ToList();

            LinkedList<Student, Worker> list = new LinkedList<Student, Worker>();

            foreach (var v in sortByMoneyPerHour)
            {
                Console.Write(v.FirstName + " ");
                Console.WriteLine(v.MoneyPerHour());
            }
        }
        public class LinkedList<T1, T2>
        {
        }
    }
}
