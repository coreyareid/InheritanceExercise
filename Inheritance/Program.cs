using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type of species and their attributes.");
            // Objects
            var Eagle = new Bird()
            {
                HasFeathers = true,
                Chirps = true,
                BuildsNest = true
            };

            Eagle.MainInformation();
            Eagle.Information();

            var Aligator = new Reptile()
            {
                HasScales = true,
                Swims = true
            };

            Aligator.MainInformation();
            Aligator.Information();

            var Lion = new Mammal()
            {
                Sound = true,
                Danger = true
            };

            Lion.MainInformation();
            Lion.Information();



        



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
