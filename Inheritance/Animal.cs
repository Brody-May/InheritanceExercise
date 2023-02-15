using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
        }

        public string Species { get; set; }
        public string Family { get; set; }
        public bool LaysEggs { get; set; }
        public int NumberOfLegs { get; set; }
    }


}
