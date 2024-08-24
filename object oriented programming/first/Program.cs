// Object-Oriented Programming (OOP) in C# is a fundamental concept that allows developers to create modular, reusable, and maintainable code by modeling real-world entities as objects.
// C# is a fully object-oriented language, meaning that it heavily relies on OOP principles.

// Classes and Objects:

// Class: A class is a blueprint for creating objects.
// It defines the properties (fields) and behaviors (methods) that the objects created from the class will have.
// Object: An object is an instance of a class.
// When you create an object, you are creating something that holds the data defined by the class and can perform the actions defined by the class.
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    public void Start()
    {
        Console.WriteLine("Car started.");
    }
}


class Program
{
    static void Main(string[] args){
    // Creating an object
    Car myCar = new Car();
    myCar.Make = "Toyota";
    myCar.Model = "Camry";
    myCar.Year = 2021;
    myCar.Start(); // Output: Car started.
    }
}

// The Four Pillars of Object-Oriented Programming:
// Encapsulation:
// Inheritance:
// Polymorphism:
// Abstraction: