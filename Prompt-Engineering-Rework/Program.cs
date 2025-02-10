using System;

public class Fibonacci
{
    /// <summary>
    /// Prints the Fibonacci series with n numbers.
    /// </summary>
    /// <param name="n">The number of terms to generate in the Fibonacci sequence.</param>
    public void PrintFibonacciSeries(int n)
    {
        // Input validation: Check for non-negative input
        if (n < 0)
        {
            throw new ArgumentException("The number of terms 'n' cannot be negative.");
        }

        // Handle base cases: n = 0 and n = 1
        if (n == 0)
        {
            return; // Nothing to print
        }

        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }

        // Initialize the first two Fibonacci numbers
        int a = 0;
        int b = 1;

        // Print the first two numbers
        Console.WriteLine(a);
        Console.WriteLine(b);

        // Iterate to generate and print the remaining Fibonacci numbers
        for (int i = 3; i <= n; i++)
        {
            int next = a + b;
            Console.WriteLine(next);
            a = b;
            b = next;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Fibonacci terms to generate:");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            Fibonacci generator = new Fibonacci();
            generator.PrintFibonacciSeries(n);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}