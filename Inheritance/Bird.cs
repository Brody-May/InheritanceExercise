using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        { 
            LaysEggs= true;
            Family = "Aves";
            Species = "Falcon";
            NumberOfLegs= 2;
        }

        public bool CanFly { get; set; }    
        public string BirdSize { get; set; }
        public string BirdColor { get; set; }
        public string BirdName { get; set;}
    }
}
