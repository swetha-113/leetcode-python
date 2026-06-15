using System;
using System.Collections.Generic;

class BuggyCalculator
{
    static void Main(string[] args)
    {
        List<int> numbers = null;

        // Bug 1: Null Reference Exception
        Console.WriteLine("Total numbers: " + numbers.Count);


        int a = 10;
        int b = 0;

        // Bug 2: Division by zero
        int result = Divide(a, b);
        Console.WriteLine("Result: " + result);


        // Bug 3: Infinite loop
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine("Loop running...");
        }


        // Bug 4: Wrong array indexing
        int[] marks = { 90, 85, 75 };

        Console.WriteLine(marks[5]);


        // Bug 5: Resource leak
        System.IO.FileStream file =
            new System.IO.FileStream("data.txt",
            System.IO.FileMode.Open);


        // Bug 6: Incorrect password check logic
        string password = "admin";

        if (password != "admin")
        {
            Console.WriteLine("Login successful");
        }
        else
        {
            Console.WriteLine("Login failed");
        }
    }


    static int Divide(int x, int y)
    {
        return x / y;
    }


    // Bug 7: Incorrect logic
    static bool IsEven(int number)
    {
        if (number % 2 == 1)
        {
            return true;
        }

        return false;
    }


    // Bug 8: Poor exception handling
    static void ReadData()
    {
        try
        {
            int value = int.Parse("abc");
            Console.WriteLine(value);
        }
        catch(Exception e)
        {
            Console.WriteLine("Error");
        }
    }
}
