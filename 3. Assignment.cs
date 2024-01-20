// Base class (Parent class)
class Vehicle
{
    public string Brand { get; set; }
    public string Color { get; set; }

    public void Drive()
    {
        Console.WriteLine("Vehicle is being driven.");
    }
}

// Derived class (Child class) inheriting from Vehicle
class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Color = "Red";
        myCar.NumberOfDoors = 4;

        Console.WriteLine($"Brand: {myCar.Brand}, Color: {myCar.Color}, Doors: {myCar.NumberOfDoors}");
        myCar.Drive(); // Accessing method from the base class

        // Additional functionality specific to Car class can be added here
    }
}
