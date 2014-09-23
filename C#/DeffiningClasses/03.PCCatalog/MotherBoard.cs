using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class MotherBoard:Component
    {
        public MotherBoard(string name, decimal price, string details = null)
            :base(name, price, details)
        {

        }
    }
}
