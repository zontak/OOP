using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Class
    {
        private List<Teacher> teacher;
        private string uniqueIdentifier;
        private string details;

        public List<Teacher> Teacher { get; set; }
        public string Details { get; set; }
        public string UniqueStringIdentifier { get; set; }

        public Class(string uniqueIdentifier,List<Teacher> teacher, string details = null)
        {
            this.UniqueStringIdentifier = uniqueIdentifier;
            this.Details = details;
            this.Teacher = teacher;
        }
    }
}
