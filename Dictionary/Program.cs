using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        #region Dictionary

        // Initialize a dictionary
        Dictionary<string, int> ages = new Dictionary<string, int>()
        {
            { "Alice", 30 },
            { "Bob", 25 },
            { "Charlie", 35 }
        };

        // Add a new key-value pair to the dictionary
        ages["David"] = 28;
       
        // Access a value in the dictionary
        Console.WriteLine("Alice's age: " + ages["Alice"]);

        // Check if a key exists in the dictionary
        if (ages.ContainsKey("Eve"))
        {
            Console.WriteLine("Eve's age: " + ages["Eve"]);
        }
        else
        {
            Console.WriteLine("Eve's age: Not found");
        }
        #endregion

        #region Tuple
        // Initialize a tuple string, int, double ("Alice", 30, 5.8)
        Tuple<string, int, double> person1 = new Tuple<string, int, double>("Alice", 30, 5.8);

        // Access tuple elements
        Console.WriteLine("Person 1: " + person1.Item1 + ", " + person1.Item2 + ", " + person1.Item3);
        #endregion

        #region liste 
        // Initialize a list
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        // Access a list element
        Console.WriteLine("First number: " + numbers[0]);
        #endregion

        // Add a new element to the list
        numbers.Add(6);

        // Remove an element from the list
        numbers.RemoveAt(2);

        // Loop through the list
        foreach (int number in numbers)
        {
            Console.WriteLine("Number: " + number);
        }

        // Use a list as a stack
        numbers.Add(7);
        numbers.Add(8);

        int top = numbers.Last();
        numbers.RemoveAt(numbers.Count - 1);
        Console.WriteLine("Top of stack: " + top);

        // Use a list as a queue
        numbers.Add(9);
        int front = numbers.First();
        numbers.RemoveAt(0);
        Console.WriteLine("Front of queue: " + front);
    }
}
/*
 * ////output///
 Alice's age: 30
Eve's age: Not found

///Tuple///
Person 1: Alice, 30, 5,8

First number: 1//
Number: 1
Number: 2
Number: 4
Number: 5
Number: 6// 3
Top of stack: 8
Front of queue: 1



 */