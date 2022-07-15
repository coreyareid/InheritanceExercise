using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        // Default Constructor
        public Bird()
        {
            MovementType = "Flying";
            Habitat = "Trees";
            TypeOfFood = "Bugs";
            CanFly = true;
        }

        // Properties
        public bool HasFeathers { get; set; } = true;
        public bool Chirps { get; set; } = true;
        public bool BuildsNest { get; set; } = true;

        // Methods
        public void Information()
        {
            if (Chirps == true)
            {
                Console.WriteLine($"Sound: {Chirps} : Annoying noises");
            }
            else
            {
                Console.WriteLine($"Sound: {Chirps}");
            }
        }
    }
}

