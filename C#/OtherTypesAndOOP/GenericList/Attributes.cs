using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Attributes : System.Attribute
    {
        private string version;
        public string Version
        {
            get { return this.version; }
            private set { this.version = value; }
        }

        public Attributes (string version)
        {
            this.Version = version;
        }
    }
}
