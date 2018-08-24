namespace StudentSystem
{
    using System;

    class Student
    {
        private string fistName;
        private string lastName;
        private string dateOfBirth;

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can`t be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can`t be empty");
                }
                this.lastName = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                if (!value.HasValue)
                {
                    throw new ArgumentException("Date of birth can`t be empty.");
                }
                this.dateOfBirth = value;
            }
        }

        public string GetFullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.lastName);
            }
        }

        public bool IsOlderThan(Student other)
        {
            bool isThisStudentOlder = this.DateOfBirth.CompareTo(other.DateOfBirth) < 0;

            return isThisStudentOlder;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }   
}