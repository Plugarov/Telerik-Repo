using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndAnonymousAndExtension
{
    class Student
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private int FN;
        private int tel;
        private string email;
        private List<int> marks;
        private Group group;

        public Student(string firstName, string lastName, int fN, int tel, string email, List<int> marks, Group Group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            FN = fN;
            this.tel = tel;
            this.email = email;
            this.marks = marks;
            this.Group = Group;
        }

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public int fN { get => FN; set => FN = value; }

        public int Tel { get => tel; set => tel = value; }

        public string Email { get => email; set => email = value; }

        public List<int> Marks { get => marks; set => marks = value; }

        public Group Group { get => group; set => group = value; }
    }
}
    