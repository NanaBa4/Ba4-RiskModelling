using System;

class Cube
{
    public static double AreaofOfC_U_B_E(double sideLength)
    {
        // Formula to calculate the surface area of a cube: 6 * side length squared
        double surfaceArea = 6 * sideLength * sideLength;
        return surfaceArea;
    }

    static void Main()
    {
        // Prompt user to enter the side length of the cube
        Console.Write("Enter the side length of the cube: ");

        // Read the input from the user and convert it to a double
        double sideLength = Convert.ToDouble(Console.ReadLine());

        // Calculate the surface area using the method
        double surfaceArea = AreaofOfC_U_B_E(sideLength);

        // Display the calculated surface area to the user
        Console.WriteLine($"The surface area of the cube with side length {sideLength} is: {surfaceArea}");

        // Wait for user input before closing the console window
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

