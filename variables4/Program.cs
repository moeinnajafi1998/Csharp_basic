using System;
// User-Defined Types
// C# allows creating custom types through classes, structs, enums, and interfaces.
// "Class": A reference type that can contain methods, fields, properties, etc.
// "Struct": A value type used to create small, lightweight objects.
// "Enum": A distinct type that consists of a set of named constants.
namespace PersonApp
{
    struct Point
    {
        public int X;
        public int Y;
    }

    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    class Person
    {
        public string? Name { get; set; }
        public Point Position { get; set; }
        public Days FavoriteDay { get; set; }
    }

    class PersonTester
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Moein Najafi";

            // Create a new Point and assign values
            Point newPosition = new Point();
            newPosition.X = 10;
            newPosition.Y = 12;

            // Assign the new Point to the Position property
            p.Position = newPosition;
            p.FavoriteDay = Days.Friday;

            Console.WriteLine(p.Name);
            Console.WriteLine($"Position: X = {p.Position.X}, Y = {p.Position.Y}");
            Console.WriteLine(p.FavoriteDay);
        }
    }
}

// ----------------------------------------
// "Interface": Defines a contract that implementing classes must follow.
interface IShape
{
    void Draw();
}
// learn soon