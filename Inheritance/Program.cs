using System;

namespace Inheritance
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }

        public void DisplayAnimalInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight}kg, Habitat: {Habitat}");
        }
    }

    class Bird : Animal
    {
        public double Wingspan { get; set; }
        public bool CanFly { get; set; }
        public string BeakType { get; set; }
        public string FeatherColor { get; set; }

        public void DisplayBirdInfo()
        {
            DisplayAnimalInfo();
            Console.WriteLine($"Wingspan: {Wingspan}m, Can Fly: {CanFly}, Beak Type: {BeakType}, Feather Color: {FeatherColor}\n");
        }
    }

    class Reptile : Animal
    {
        public bool IsVenomous { get; set; }
        public string ScaleType { get; set; }
        public double BodyLength { get; set; }
        public string ColdBlooded { get; set; }

        public void DisplayReptileInfo()
        {
            DisplayAnimalInfo();
            Console.WriteLine($"Is Venomous: {IsVenomous}, Scale Type: {ScaleType}, Body Length: {BodyLength}m, Cold-Blooded: {ColdBlooded}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird parrot = new Bird()
            {
                Name = "Rainbow Parrot",
                Age = 3,
                Weight = 1.5,
                Habitat = "Rainnforest",
                Wingspan = 0.8,
                CanFly = true,
                BeakType = "Curved",
                FeatherColor = "Red, Blue, Yellow"
            };

            Console.WriteLine("Bird Details:");
            parrot.DisplayBirdInfo();

            Reptile python = new Reptile()
            {
                Name = "Burmese Python",
                Age = 5,
                Weight = 35,
                Habitat = "Swamps and Grassslands",
                IsVenomous = false,
                ScaleType = "Smooth",
                BodyLength = 4.5,
                ColdBlooded = "Yes"
            };

            Console.WriteLine("Reptile Details:");
            python.DisplayReptileInfo();
        }
    }
}

