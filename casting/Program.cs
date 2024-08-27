// In C#, type casting refers to the process of converting a variable from one data type to another.
// C# is a strongly typed language, meaning that once a variable is declared as a certain type,
// it cannot hold a value of a different type without an explicit or implicit conversion.

// Types of Casting in C#
// There are two main types of casting in C#:

// Implicit Casting (Automatic Type Conversion):
// The compiler automatically converts a smaller data type to a larger data type.
// No data is lost during the conversion.
// There is no need to use any special syntax for implicit casting.
int num = 100;
double decimalNum = num;  // Implicit casting from int to double
Console.WriteLine(decimalNum);


// Explicit Casting (Manual Type Conversion):
// The programmer explicitly converts a larger data type to a smaller data type or between incompatible types.
// You use parentheses to specify the target type.
// Explicit casting may result in data loss if the target type cannot hold the original data.
double decimalNum2 = 99.99;
int num2 = (int)decimalNum2;  // Explicit casting from double to int
Console.WriteLine(num2);


// Special Types of Casting
// In addition to these basic types, C# provides other casting mechanisms:

// Using the Convert Class:
// The Convert class provides methods to convert between different types.
// It handles cases where explicit casting cannot be done directly.
string str = "123";
int num3 = Convert.ToInt32(str);
Console.WriteLine(num3);


// Parse() and TryParse() Methods:
// These methods are used to convert strings to numeric types.
// Parse() throws an exception if the conversion fails.
// TryParse() returns true or false indicating success or failure.
string str2 = "123";
int num4;
bool success = int.TryParse(str2, out num4);
Console.WriteLine(success);


// is and as Operators:
// These operators are used for type checking and safe casting, especially with reference types.
object obj = "Hello, World!";

if (obj is string str3)
{
    Console.WriteLine(str3);
}

// Using `as`
string result = obj as string;
if (result != null)
{
    Console.WriteLine(result);
}
