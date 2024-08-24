// Polymorphism:
// olymorphism allows objects to be treated as instances of their parent class rather than their actual class.
// It can be achieved through method overriding and interfaces.
// This enables you to write more flexible and extensible code.
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}


class Program{
    static void Main(string[] args){
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        myDog.Speak(); // Output: Woof!
        myCat.Speak(); // Output: Meow!
        
    }
}