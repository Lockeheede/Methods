using System;
    class EntryPoint
    {
        static void Main()//The Main in itself is a method
        {
        PrintingNames();//When you declare a method, you are asking it to
        //Do everything it does, which is usually one thing
        //Which you can all on multiple times. 
        //This is good as opposed to typing something over and over
        PrintingNames();
        Console.WriteLine("Inbetween methods");
        PrintingNames();
        PrintingNames();//Remember the parentheses. This is how you distinguish
        //Between variables and methods

        }
        //Initalizing a method happens outside of the Main method scope
        //A basic version uses static void
        static void PrintingNames()
        {
        Console.WriteLine("My name is Lockes The Thief!");
        Console.WriteLine("Her name is Reflex The Muse!");
        Console.WriteLine("We are The Thief & The Muse!");
        Console.WriteLine();
        }
    }
