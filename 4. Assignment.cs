using System;

/* A key idea in object-oriented programming is inheritance, which permits a class (also known as a derived or child class) to inherit attributes and methods from another class (also known as a base or parent class). Class relationships allow hierarchies to be created and code to be reused.

The: (colon) symbol can be used in C# to create inheritance, signifying that one class is descended from another. find example below */

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
