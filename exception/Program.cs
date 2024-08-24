// Exception handling in C# is a mechanism that helps developers manage errors and other exceptional conditions that can occur during the execution of a program.
// It allows the program to continue running or fail gracefully when unexpected situations arise.
// This is accomplished using try, catch, finally, and throw keywords.

// Key Components of Exception Handling in C#:

// try Block:
// The code that might throw an exception is placed inside a try block.
// If an exception occurs, the control is transferred to the appropriate catch block.

// catch Block:
// The catch block handles the exception. You can have multiple catch blocks to handle different types of exceptions separately.
// If no catch block matches the thrown exception, it will propagate up the call stack

// finally Block:
// The finally block is optional and is used to execute code regardless of whether an exception was thrown or caught.
// It’s typically used for cleaning up resources, such as closing files or releasing memory

// throw Statement:
// The throw statement is used to explicitly throw an exception.
// It can be used within a catch block to rethrow the same exception or throw a new one.


class Program
{
    static void Main()
    {
        try
        {
            int dividend = 10;
            int divisor = 0;
            int result = dividend / divisor; // This will throw a DivideByZeroException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}