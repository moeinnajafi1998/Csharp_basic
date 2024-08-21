// use below command to create new console app
//  dotnet new console -n NameOfAPP



// Primitive Data Types

// "int": Stores integer values 
// The int data type in C# is a 32-bit signed integer. This means it can store whole numbers within a specific range.
// Range of int in C#
// -2^31 to 2^31-1
// Minimum Value: -2,147,483,648
// Maximum Value: 2,147,483,647
int age = 30;
Console.WriteLine(age);
// int outOfRange = 2147483648; => Invalid (Compiler Error)
// -------------------------

// "float": Stores single-precision floating-point numbers
float temperature = 36.6f;
Console.WriteLine(temperature);
// -------------------------

// "double": Stores double-precision floating-point numbers
double pi = 3.14159;
Console.WriteLine(pi);
// -------------------------

// "decimal": Stores decimal numbers with high precision, often used for financial calculations.
decimal price = 19.99m;
Console.WriteLine(price);
// -------------------------

// "char": Stores a single character
char grade = 'A';
Console.WriteLine(grade);
// -------------------------

// "bool": Stores a Boolean value (true or false)
bool isFinished = true;
Console.WriteLine(isFinished);
// -------------------------

// "byte": Stores an 8-bit unsigned integer (0 to 255)
byte level = 255;
Console.WriteLine(level);
// -------------------------

// "sbyte": Stores an 8-bit signed integer (-128 to 127).
sbyte temperature2 = -30;
Console.WriteLine(temperature2);
// -------------------------

// "short": Stores a 16-bit signed integer (-32,768 to 32,767)
short population = 32767;
Console.WriteLine(population);
// -------------------------

// "ushort": Stores a 16-bit unsigned integer (0 to 65,535).
ushort distance = 65535;
Console.WriteLine(distance);
// -------------------------

// "long": Stores a 64-bit signed integer.
long distanceToMars = 225000000000;
Console.WriteLine(distanceToMars);
// -------------------------

// "ulong": Stores a 64-bit unsigned integer.
ulong nationalDebt = 25000000000000;
Console.WriteLine(nationalDebt);
// -------------------------
