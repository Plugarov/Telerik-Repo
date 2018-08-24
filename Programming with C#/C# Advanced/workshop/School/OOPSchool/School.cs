namespace OOPSchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        private string freeTextBlock;

        public School(string freeTextBlock)
        {
            this.FreeTextBlock = freeTextBlock;
        }

        public string FreeTextBlock { get => this.freeTextBlock; set => this.freeTextBlock = value; }
    }
}
