
// Working with the console in C# is a fundamental skill, especially for beginners.
// The System.Console class in C# provides methods to interact with the command-line interface (CLI).
// You can use this to display output, read input, and control how text is formatted or colored.

// Writing to the Console
// Console.WriteLine: This method outputs a line of text and automatically appends a newline character at the end
Console.WriteLine("Hello, World!");
// Console.Write: This method outputs text without adding a newline.
Console.Write("Hello, ");
Console.Write("World!");


// Reading Input from the Console
// Console.ReadLine: Reads the entire line of text input by the user as a string.
Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");


// Console.ReadKey: Reads a single character input by the user, which is often useful for pausing the program.
Console.WriteLine("Press any key to continue...");
Console.ReadKey();


// Formatting Output
int age = 25;
Console.WriteLine("You are {0} years old.", age);
Console.WriteLine($"You are {age} years old.");


// Working with Colors
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("This text is green.");
Console.ResetColor(); // Resets to the default colors

// Clearing the Console
Console.Clear();

// Error Output
Console.Error.WriteLine("An error occurred!");
