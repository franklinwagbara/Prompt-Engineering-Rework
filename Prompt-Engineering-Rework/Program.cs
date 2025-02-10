using System;

public class FibonacciGenerator
{
    /// <summary>
    /// Prints the Fibonacci series with n numbers.
    /// </summary>
    /// <param name="n">The number of terms to generate in the Fibonacci sequence.</param>
    public void PrintFibonacciSeries(int n)
    {
        // Input validation
        if (n < 0)
        {
            Console.WriteLine("Input must be a non-negative integer.");
            return;
        }

        if (n == 0)
        {
            return; // Nothing to print
        }

        long a = 0, b = 1, c;

        Console.WriteLine(a); // Print the first term

        if (n == 1)
        {
            return;
        }

        Console.WriteLine(b); // Print the second term

        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Fibonacci terms to generate:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            FibonacciGenerator generator = new FibonacciGenerator();
            generator.PrintFibonacciSeries(n);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}