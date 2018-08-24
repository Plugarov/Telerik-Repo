namespace OOPSchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Discipline : School
    {
        private string name;
        private int numberLectures;
        private int numberExercises;

        public Discipline(string name, int numberLectures, int numberExercises) : base("Disciplines : free text block is empty")
        {
            this.Name = name;
            this.NumberLectures = numberLectures;
            this.NumberExercises = numberExercises;
        }

        public Discipline(string freeTextBlock, string name, int numberLectures, int numberExercises) : base(freeTextBlock)
        {
            this.Name = name;
            this.NumberLectures = numberLectures;
            this.NumberExercises = numberExercises;
        }

        public string Name { get => this.name; set => this.name = value; }

        public int NumberLectures { get => this.numberLectures; set => this.numberLectures = value; }

        public int NumberExercises { get => this.numberExercises; set => this.numberExercises = value; }
    }
}
