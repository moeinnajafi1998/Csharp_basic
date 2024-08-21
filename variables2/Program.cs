// Reference Types
// Reference types store references to their data (objects), rather than the data itself.

// "object": The base type for all data types in C#. It can store any type of data.
object obj = 42;
Console.WriteLine(obj);
// -------------------------

// "string": Although string is a reference type, it is commonly used like a value type.
string message = "Hello, World!";
Console.WriteLine(message);
// -------------------------

// "dynamic": A special type that can store any type of data and is resolved at runtime.
dynamic value = 100;
value = "Now I'm a string";
Console.WriteLine(value);
// -------------------------

// "array": A collection of variables of the same type.
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(string.Join(", ", numbers));
// -------------------------
