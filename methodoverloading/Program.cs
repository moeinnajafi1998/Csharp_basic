// With method overloading, multiple methods can have the same name with different parameters(signature):



class Program{
    static int sampleMethod(int x)
    {
        return x;
    }
    static int sampleMethod(int x, int y)
    {
        return x + y;
    }
    static void Main(string[] args)
    {
        int myNum1 = sampleMethod(8);
        int myNum2 = sampleMethod(8,7);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Int: " + myNum2);
    }
}
