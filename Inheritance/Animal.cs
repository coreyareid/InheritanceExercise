using System;
namespace Inheritance
{
    public class Animal
    {
       // Default Constructor
        public Animal()
        {

        }

        // Fields

        // Properties
        public string MovementType { get; set; }
        public string Habitat { get; set; }
        public string TypeOfFood { get; set; }
        public bool CanFly { get; set; }

        // Methods
        public void MainInformation()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Type of animal: {GetType().Name}");
            Console.WriteLine($"How it moves: {MovementType}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Food source: {TypeOfFood}");
            Console.WriteLine($"Ability to fly: {CanFly}");
            Console.WriteLine();
        }

    }
}

