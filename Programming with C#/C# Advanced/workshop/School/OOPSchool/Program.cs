namespace OOPSchool
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
            List<Student> students = new List<Student>()
            {
                new Student(2,"Pena")
            };
            students.Add(new Student(1, "Goshko"));

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher("Pepa Lazarova"),
            };
            teachers.Add(new Teacher("Svurshen", "Kasabov"));

            List<Discipline> disciplines = new List<Discipline>
            {
                new Discipline("Math",2,1),
                new Discipline("Bulgarian", 4, 3),
            };
            disciplines.Add(new Discipline("Geograpy", 4, 3));

            SchoolClass FourthB = new SchoolClass("This is 4B class", students, teachers);

            List<SchoolClass> classes = new List<SchoolClass>() { FourthB };

            

        }

        public void LoopElements(object o)
        {

        }
    }
}
