
// Arrays and Collections in C# are fundamental concepts used to store and manage groups of objects.
// While they both serve similar purposes, they differ significantly in terms of flexibility, functionality, and performance.
// Let's explore both in detail.

// Arrays in C#
// Arrays are a collection of variables of the same type stored in a contiguous block of memory. They are a fundamental data structure in C#.
// Characteristics of Arrays:
// Fixed Size: The size of an array is determined when it is created and cannot be changed.
// Type-Safe: All elements in the array are of the same type.
// Indexed Access: Elements in an array are accessed using zero-based indexing.
// Performance: Arrays provide very fast access to elements due to their contiguous memory layout.

int[] numbers = new int[5];      // Declaring an array of integers with 5 elements
numbers[0] = 10;                 // Setting the first element
numbers[1] = 20;                 // Setting the second element

// Iterating through the array
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Limitations of Arrays:
// Fixed size: Once created, the size of an array cannot be modified.
// Limited functionality: Arrays do not provide methods for adding, removing, or searching elements (beyond basic index access).



// Collections in C#
// Collections are more flexible data structures that can grow and shrink dynamically.
// The .NET Framework provides a wide variety of collection types, each optimized for different use cases.
// Types of Collections:

// List<T>: A dynamically sized array-like collection that can grow or shrink as needed. It is the most commonly used collection in C#.
List<int> numbers2 = new List<int>();
numbers2.Add(10); // Add an element
numbers2.Add(20);
numbers2.Remove(10); // Remove an element
for (int i = 0; i < numbers2.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

// Dictionary<TKey, TValue>: A collection of key-value pairs. It allows fast lookups based on keys.
Dictionary<string, int> ages = new Dictionary<string, int>();
ages["John"] = 25;
ages["Jane"] = 30;
int age = ages["John"]; // Access value using the key
foreach (KeyValuePair<string, int> kvp in ages)
{
    Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
}

// HashSet<T>: A collection that contains no duplicate elements and has fast lookup and insertion.
HashSet<string> uniqueNames = new HashSet<string>();
uniqueNames.Add("Alice");
uniqueNames.Add("Bob");
uniqueNames.Add("Alice"); //duplicated
foreach (string name in uniqueNames)
{
    Console.WriteLine(name);
}

// Queue<T>: A first-in, first-out (FIFO) collection.
Queue<string> queue = new Queue<string>();
queue.Enqueue("First");
queue.Enqueue("Second");
string next = queue.Dequeue(); // Removes "First"
while (queue.Count > 0)
{
    string item = queue.Dequeue(); // Removes and returns the element at the front of the queue
    Console.WriteLine(item);
}

// Stack<T>: A last-in, first-out (LIFO) collection.
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
int top = stack.Pop(); // Removes 2
while (stack.Count > 0)
{
    int item = stack.Pop(); // Removes and returns the top element
    Console.WriteLine(item);
}
// Characteristics of Collections:
// Dynamic Sizing: Collections like List<T> can automatically resize as elements are added or removed.
// Type Safety: Generics ensure type safety, preventing type errors at runtime.
// Rich API: Collections provide many built-in methods like Add(), Remove(), Contains(), and Find() that simplify many tasks.
// Various Implementations: Different types of collections provide different performance characteristics and use cases (e.g., List<T> for dynamic arrays, Dictionary<TKey, TValue> for key-value pairs).

// Arrays vs. Collections

// Feature	    Array	                Collection
// Size	        Fixed	                Dynamic
// Type_Safety	Yes	                    Yes(with Generics)
// Performance	Faster(no overhead)	    Slightly slower due to overhead
// Flexibility	Less_flexible	        Highly_flexible
// Built-in_Methods	Limited (Length)	Extensive (Add, Remove, etc.)


// When to Use What?
// Use Arrays when the size is known ahead of time, and performance is critical.
// Use Collections when you need dynamic sizing, advanced functionalities, or when the size of the data changes frequently.
// Understanding when to use arrays versus collections in C# is crucial for writing efficient and maintainable code.
