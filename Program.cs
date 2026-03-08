using System;
using System.Collections.Generic;
using CSharpTestBench;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();

        // Standard case
        var items = new List<Item> { new Item { Price = 10 }, new Item { Price = 20 } };
        Console.WriteLine($"Total: {calculator.CalculateTotal(items)}");

        // Crash case: Empty list or null
        try {
            Console.WriteLine("Testing empty list...");
            // In C# Sum() on an empty list returns 0, but if the list itself is null it crashes.
            // We'll test null to ensure the agent adds a proper guard.
            Console.WriteLine($"Result: {calculator.CalculateTotal(null!)}");
        } catch (Exception ex) {
            Console.WriteLine($"Caught expected crash: {ex.Message}");
        }
    }
}
