using System;

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