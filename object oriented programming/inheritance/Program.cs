// Inheritance:
// Inheritance allows one class to inherit fields and methods from another class.
// The class that is inherited from is called the base class (or parent class), and the class that inherits is called the derived class (or child class).
// Inheritance promotes code reuse and establishes a natural hierarchy between classes
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

class Program{
    static void Main(string[] args){
        Dog myDog = new Dog();
        myDog.Eat(); // Output: Eating...
        myDog.Bark(); // Output: Barking...
    }
}