using System;
//Note, the Split() method converts strings into arrays.
    class EntryPoint
    {
        static void Main()
        {
        PrintNames("Lockes", "The Thief");
        PrintNames("Creative", "Reflex", "The Muse");
        PrintNames("Meek", "Ratface", ConsoleColor.Yellow);

        Console.WriteLine(AreaOfShape(15, 26));
        }
    static void PrintNames(string firstName, string lastName)
    {
        Console.WriteLine($"My name is {firstName} {lastName}!");

    }
    static void PrintNames(string firstName, string middleName, string lastName)//You can have methods with the same name, but different signature, aka arguments
    {
        Console.WriteLine($"My name is {firstName} {middleName} {lastName}!");
    }
    static void PrintNames(string firstName, string lastName, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"My name is {firstName} {lastName}!");
        Console.ResetColor();
    }
    
    ///Square = l * w; Rectangle = l * w; Triangle s = (a + b + c)/2 then square root of (s-a)(s-b)(s-c)
    ///Create an overloading method for finding the area of a square, rectangle or triangle 
    static double AreaOfShape(double sideA)
    {
        return sideA * sideA;
    }
    static double AreaOfShape(double sideA, double sideB)
    {
        return sideA * sideB;
    }
    static double AreaOfShape(double sideA, double sideB, double sideC)
    {
        double sum = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt((sum - sideA) * (sum - sideB) * (sum - sideC));

        return area;
    }
    
}

