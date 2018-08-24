namespace DelegatesAndAnonymousAndExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Group
    {
        public Group(int GroupNumber, string DepartmentName)
        {
            groupNumber = GroupNumber;
            departmentName = DepartmentName;
        }

        private int groupNumber;
        private string departmentName = string.Empty;

        public string DepartmentName { get => this.departmentName; set => this.departmentName = value; }

        public int GroupNumber { get => this.groupNumber; set => this.groupNumber = value; }

    }
}
