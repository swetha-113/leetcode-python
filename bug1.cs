using System;

def your_function(param):
"""One-line summary.

Args:
param: Description.

Returns:
Description of return value.
"""
pass
{
    static int total = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        if (!int.TryParse(Console.ReadLine(), out int n))
        { Console.WriteLine("Invalid input."); return; }

        int result = DivideByNumber(100, n);

        Console.WriteLine("Result: " + result);

        CalculateTotal(n);

        Console.WriteLine("Total: " + total);
    }

    static int DivideByNumber(int a, int b)
    {
        return a / b; // Possible divide by zero
    }

    static void CalculateTotal(int value)
    {
        for (int i = 0; i < value; i++)  // Fixed: <= changed to < (off-by-one)
        {
            total += i;
        }

        if (value > 10)
        {
            Console.WriteLine("Large number");
        }
        else if (value > 20) // Logical error: unreachable condition
        {
            Console.WriteLine("Very large number");
        }
    }

    static string GetUserName()
    {
        string name = null;
        return name.ToUpper(); // Null reference exception
    }
}
