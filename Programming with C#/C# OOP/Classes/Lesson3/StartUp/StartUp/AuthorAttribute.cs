namespace StartUp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class AuthorAttribute : Attribute
    {
        private string authorName;
        private DateTime lastUpdate;

        public AuthorAttribute(string authorName)
        {
            this.authorName = authorName;
            this.lastUpdate = DateTime.Now;
        }

        public string AuthorName { get; set; }

        public DateTime LastUpadate { get; set; }
    }
}
