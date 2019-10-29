using System;
    class EntryPoint
    {
        static void Main()
        {
        PrintNames("Lockes", "The Thief");
        PrintNames("Creative", "Reflex", "The Muse");
        PrintNames("Meek", "Ratface", ConsoleColor.Yellow);
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

}

