using System;
    class EntryPoint
    {
        //discussion of the keywords in methods
        static void Main()//static will be discussed in OOP
        //Void represents what a method returns, void means it will return nothing
        //They are expected to do something but aren't required to return anything
        {
        Console.WriteLine();//This WriteLine method is void
        PrintingNames("Lockes The Thief", "Reflex The Muse", "The Thief & The Muse");//This new version of the PrintingNames method uses arguements
        PrintingNames("Meek Ratface", "Dirty Fatbastard", "The Ogre");//Using it this way, you can come up with different results using the same method

        ColorfulNames("Reflex The Muse", ConsoleColor.Green);

        }
    static void PrintingNames(string firstName, string secondName, string teamName)
    { 
        //This method gives three arguements for the first character, second character, and their team names
        Console.WriteLine($"My name is {firstName}!");
        Console.WriteLine($"Your name is {secondName}!");
        Console.WriteLine($"We are {teamName}!");
        Console.WriteLine();
    }

    static void ColorfulNames(string text, ConsoleColor color)
    {
        /*This works a little differently, because of the fact that you use
         * Console color different from strings. It is a MUST to know how 
         * something works before putting it into your method
         */
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}

