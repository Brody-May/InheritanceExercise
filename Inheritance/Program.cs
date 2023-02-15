using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird myBird = new Bird();
            myBird.CanFly = true;
            myBird.BirdName= "Penguin";
            myBird.BirdSize = "Medium";
            myBird.BirdColor = "Black and White";

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile myReptile = new Reptile()
            {
                IsColdBlooded= true,
                IsScaly= true,
                Habitat = "Desert",
                Diet = "Insects"
            };

            var myAnimals = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimals) 
            {
                Console.WriteLine($"Species: {animal.Species}");
                Console.WriteLine($"Family: {animal.Family}");
                Console.WriteLine($"It has {animal.NumberOfLegs} legs");
                Console.WriteLine($"LaysEggs: {animal.LaysEggs}");
                Console.WriteLine("");
            }
            
        }
    }
}
