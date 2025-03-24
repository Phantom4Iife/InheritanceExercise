using System;

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
