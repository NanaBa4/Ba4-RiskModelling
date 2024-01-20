using System;

using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter the first number
        Console.Write("Enter the first number: ");

        // Read the input from the user and convert it to a double
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Prompt user to enter the second number
        Console.Write("Enter the second number: ");

        // Read the input from the user and convert it to a double
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform multiplication and division
        double multiplyResult = num1 * num2;
        double divideResult = num1 / num2;

        // Display the results to the user
        Console.WriteLine($"The result of multiplication: {num1} * {num2} = {multiplyResult}");
        Console.WriteLine($"The result of division: {num1} / {num2} = {divideResult}");

        // Wait for user input before closing the console window
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
