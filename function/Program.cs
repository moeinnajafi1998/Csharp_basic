using System;

// In C#, both functions and methods represent blocks of code that perform specific tasks,
// but they have key differences in terms of how they are defined and used

// Definition:
// Function: A function is a more general term referring to any block of code that can be called by name.
// In C#, however, the term "function" is not commonly used to describe code structures. 
// The more specific term "method" is used instead.
// Method: A method is a function that is associated with an object or a class. 
// In C#, all functions that belong to a class or struct are called methods. 
// Methods can be instance methods (which operate on a specific object) or static methods (which belong to the class itself and are not tied to a specific object instance).

namespace FunctionNameSpace
{
    // This is a method in C#
    public class Calculator
    {
        // Instance method
        public int Add(int a, int b)
        {
            return a + b;
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            // Usage
            Calculator calc = new Calculator();
            int sum = calc.Add(5, 3);   
            Console.WriteLine(sum);
            int difference = Subtract(5, 3); // Static method call
            Console.WriteLine(difference);
        }

        // Static method
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}