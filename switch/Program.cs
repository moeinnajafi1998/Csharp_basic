// switch Statement
// For scenarios with multiple conditions based on a single variable,
// the switch statement can be more readable than multiple if-else statements.

int number = 2;

switch (number)
{
    case 1:
        Console.WriteLine("The number is 1");
        break;
    case 2:
        Console.WriteLine("The number is 2");
        break;
    case 3:
        Console.WriteLine("The number is 3");
        break;
    default:
        Console.WriteLine("The number is not 1, 2, or 3");
        break;
}