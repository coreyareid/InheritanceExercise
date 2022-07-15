using System;
namespace Inheritance
{
    public class Mammal : Animal
    {
        // Default Constructor
        public Mammal()
        {
            MovementType = "Runs";
            Habitat = "Open Plains";
            TypeOfFood = "Smaller Animals";
            CanFly = false;
        }

        // Properties
        public bool Sound { get; set; } = true;
        public bool Danger { get; set; } = true;

        // Methods
        public void Information()
        {
            Console.WriteLine(Sound == true ? $"Sound: {Sound} : ROOOAAARS!!" : "Makes no sound");
            Console.WriteLine(Danger == true ? $"Dangerous: {Danger} : Stay Away!" : "Harmless");
        }
    }
}

