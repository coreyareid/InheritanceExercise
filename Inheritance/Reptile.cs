using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        // Default Constructor
        public Reptile()
        {
            MovementType = "Crawls";
            Habitat = "Swamps";
            TypeOfFood = "Anything";
            CanFly = false;
        }

        // Properties
        public bool HasScales = true;
        public bool Swims = true;

        // Methods
        public void Information()
        {
            Console.WriteLine($"Ability to swim: {Swims}");
            Console.WriteLine($"Tough skin: {HasScales}");
        }
    }
}

