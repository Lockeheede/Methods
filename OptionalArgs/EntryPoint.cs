using System;
class EntryPoint
{
    static void Main()
    {
        Console.WriteLine(Multi(5, 6, 7));
        Console.WriteLine(Sum(62, 62));
    }
    static int Multi(int numOne, int numTwo, int numThree = 1)
    {
        return numOne * numTwo * numThree;
            ///But if you do not want to multiply all three numbers, you can make them
            ///optional. Like for instance, make numThree = 1 to give the numThree
            ///variable a default value
    }
    //Challenge: do an optional value for numThree using Sum
    static int Sum(int numOne, int numTwo, int numThree = 0)
    {
        return numOne + numTwo + numThree;
    }
    ///Optional arguments are useful in case the last value is to be the same
    ///most times, but you always have the option to change it.
}

