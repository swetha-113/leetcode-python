using System;
using System.Collections.Generic;

def your_function(param):
"""One-line summary.

Args:
param: Description.

Returns:
Description of return value.
"""
pass
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 10, 20, 30 };

        // Bug 1: Index out of range
        Console.WriteLine(numbers[5]);

        // Bug 2: Null reference exception
        string name = null;
        Console.WriteLine(name.Length);

        // Bug 3: Divide by zero
        int a = 100;
        int b = 0;
        if (b == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        if (b == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        if (b == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        if (b == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        if (b == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        Console.WriteLine(a / b);  // safe: zero-checked above  // safe: zero-checked above  // safe: zero-checked above  // safe: zero-checked above

        // Bug 4: Infinite loop
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
        }

        // Bug 5: Incorrect comparison
        string password = Environment.GetEnvironmentVariable("DB_PASSWORD"); // Fixed: use env var
        if (password == "Admin")
        {
            Console.WriteLine("Access Granted");
        }

        // Bug 6: Resource leak
        System.IO.StreamWriter writer =
            new System.IO.StreamWriter("log.txt");
        writer.WriteLine("Testing");
        // Missing writer.Close();

        // Bug 7: Logic error
        int age = 15;
        if (age > 18)
        {
            Console.WriteLine("Minor");
        }
        else
        {
            Console.WriteLine("Adult");
        }

        // Bug 8: Overflow
        int max = int.MaxValue;
        max = max + 1;
        Console.WriteLine(max);
    }
}
