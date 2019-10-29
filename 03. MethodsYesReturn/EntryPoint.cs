using System;
    class EntryPoint
    {
        static void Main()
        {
        Console.WriteLine(Addition(777, 23));
        //This returns the sum, which is numOne + numTwo
        //You can also store it into a variable
        int resultOfAddition = Addition(1111, 420);
        Console.WriteLine(resultOfAddition);
        //You can also put methods within methods
        int resultOfMultiplicationOfAddition = Multiplication(Addition(13, 5), Addition(10, 24));
        Console.WriteLine(resultOfMultiplicationOfAddition);
        }
    //When you use methods that do return a value, two things change
    static int Addition(int numOne, int numTwo)//First you change the void to the data type you are trying to return
    {
        int sum = numOne + numTwo;//You must create a new variable to be returned

        return sum;//Second you add a return keyword, this send the value of the method back. It must be the same as the method
        //data type
    }
    static int Multiplication(int numOne, int numTwo)
    {
        int product = numOne * numTwo;

        return product;
    }

    }

