using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            LaysEggs = true;
            Family = "Lacertidae";
            Species = "phrynosomatid";
            NumberOfLegs = 4;
        }
        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
    }
}
