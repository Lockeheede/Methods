using System;
class EntryPoint
{
    static void Main()
    {
        string firstName = "Reflex";
        string lastName = "The Muse";
        //Console.WriteLine(Sum(24, 22, 222, 21, 25, 365, 777, 111, 610, 016, 33, 36, 39));
        //PlaceHolderMethod();
        WriteLinePlaceholders("[0] [1]", firstName, lastName);
    }
    static int Sum(params int[] numbers)
    {
        ///Variable methods take a varying amount of methods
        ///There are still type restrictions
        ///They must be the last argument
        ///Use a special params keyword when using variable methods
        ///The params keyword lets you use as many arguments as you want! 
        ///Use an array to store the elements
       
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static void PlaceHolderMethod()
    {
        //placeholder method in writeline is a type of variable method
        //You can declare variables and then use placeholders to
        //print them out

        int numOne = 33;
        int numTwo = 36;
        int numThree = 610;
        int numFour = 016;
        Console.WriteLine("{0} {1} {2} {3} {2} {1} {0}", numOne, numTwo, numThree, numFour);
    }

    //Challenge: have a set number of strings, or ints, or any kind of variable
    //And use the variable method to print them out as placeholders

    static void WriteLinePlaceholders(string text, params string[] variables)
    {
        string newText = string.Empty;
        int placeHolderIndex = 0;

        for(int i = 0; i < text.Length; i++)
        {
            if (text[i].ToString() == "[")
            {
                placeHolderIndex = int.Parse(text[i + 1].ToString());
                newText += variables[placeHolderIndex];
                ///This placeholder takes the character [i+1] and you use the
                ///.ToString method to turn it into a string
                ///Then you parse it as an integer in order to read
                ///From the method the placeholder as its integer representation
                i += 2;
            }
            else
            {
                newText += text[i];
            }
        }
        Console.WriteLine(newText);

    }
        
}

