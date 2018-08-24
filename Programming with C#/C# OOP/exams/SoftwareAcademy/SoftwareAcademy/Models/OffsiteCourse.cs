namespace SoftwareAcademy.Models
{
    using SoftwareAcademy.Interfaces;

    public class OffsiteCourse : Course, ICourse, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                Validator.checkIfNullOrEmpty(value);
                this.town = value;
            }
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.town))
            {
                return base.ToString() + string.Format(" Town = {0};", this.town);
            }
            return base.ToString();
        }
    }
}
