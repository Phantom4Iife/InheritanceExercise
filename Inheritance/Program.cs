using System;

namespace Inheritance
{
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

