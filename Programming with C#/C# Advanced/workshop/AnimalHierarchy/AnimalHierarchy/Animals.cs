using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animals : IAnimal
    {
        private string name;
        private int age;
        private string sex;

        public string Name { get => name; set => name = value; }

        public int Age { get => age; set => age = value; }

        public string Sex { get => sex; set => sex = value; }

        public virtual void ProduceSound()
        {
            Console.WriteLine("woo");
        }
    }
}
