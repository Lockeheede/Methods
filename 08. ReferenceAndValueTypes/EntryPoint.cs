using System;

    class EntryPoint
    {
        static void Main()
        {
        ///An array is a reference type. So, copying to an array with an array
        ///Does not copy the values into the 2nd array, but instead points it
        ///To the array. For example:

        int number = 3;
        int secondNum = number;

        number = 10;

        Console.WriteLine(secondNum);//This prints out 3, because it is copying, not referencing

        int[] array = { 1, 2, 3, 4, 5 };
        int[] secondArray = array;

        array[2] = 10;

        Console.WriteLine(secondArray[2]); //This prints out 10, because it is referencing, not copying

        }
    }
