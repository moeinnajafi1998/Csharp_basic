// "if" statements are fundamental to controlling the flow of a program.
// They allow you to execute specific blocks of code based on whether a condition is true or false

// structure
// if (condition)
// {
    // Code to execute if the condition is true
// }
// else if (condition2)
// {
    // Code to execute if the condition2 is true
// }
// how much we need else if
// else
// {
//     // Code to execute any conditions been true
// }

int number = 10;

if (number > 10)
{
    Console.WriteLine("The number is greater than 10");
}
else if (number == 10)
{
    Console.WriteLine("The number is exactly 10");
}
else
{
    Console.WriteLine("The number is less than 10");
}

// Nested if Statements
int number2 = 21;

if (number2 > 10)
{
    Console.WriteLine("The number2 is greater than 10");

    if (number2 > 20)
    {
        Console.WriteLine("The number2 is also greater than 20");
    }
}

// Logical Operators
// In if statements, logical operators can be used to combine multiple conditions:

// && (AND): All conditions must be true.
// || (OR): At least one condition must be true.
// ! (NOT): Inverts the condition.

int number3 = 5;

if (number3 > 10 && number3 < 20)
{
    Console.WriteLine("The number3 is between 10 and 20");
}

if (number3 < 10 || number3 > 20)
{
    Console.WriteLine("The number3 is outside the range 10-20");
}

if (!(number3 == 15))
{
    Console.WriteLine("The number3 is not 15");
}

// Ternary Operator
// The ternary operator is a shorthand for an if-else statemen
int number4 = 5;
string result = (number4 > 0) ? "Positive" : "Negative";
Console.WriteLine(result);