using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public abstract class People
    {
        private string details;
        private string name;

        public People(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
        }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
