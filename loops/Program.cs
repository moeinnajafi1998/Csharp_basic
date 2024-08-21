
// Loops in C# are control structures that allow you to execute a block of code multiple times.
// C# provides several types of loops, each suited for different scenarios.

// "for" loop
// The for loop is typically used when the number of iterations is known beforehand.
// It consists of three parts: the initialization, the condition, and the iteration expression
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}

// "while" loop
// The while loop executes a block of code as long as a specified condition is true.
//  It's ideal when the number of iterations is not known in advance.
int count = 0;
while (count < 5)
{
    Console.WriteLine("Count: " + count);
    count++;
}

// "do-while" loop
// The do-while loop is similar to the while loop, but it guarantees that the loop body is executed at least once, even if the condition is false from the start.
int count2 = 0;
do
{
    Console.WriteLine("count2: " + count2);
    count2++;
} while (count2 < 5);

// "foreach" loop
// The foreach loop is used to iterate over collections (like arrays, lists, etc.) without needing an index variable.
// It's ideal for when you want to access each element in a collection.
string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
} 

// break and continue Statements

// break: Exits the loop immediately.
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}
// continue: Skips the current iteration and proceeds with the next iteration.
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}