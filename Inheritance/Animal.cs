using System;
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