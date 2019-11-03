using System;

class EntryPoint
{
    static void Main()
    {
        ///The ref keyword makes any type a reference type
        int number = 0;
        int numberOne = 5;
        int numberTwo = 5;
        Console.WriteLine(number);
        IncreaseByOne(ref number);
        Console.WriteLine(number);
        IncreaseByOne(number);
        Console.WriteLine(number);
        IncreaseByOne(ref numberOne, ref numberTwo);
        Console.WriteLine(numberOne);
        Console.WriteLine(numberTwo);

        AreaAndParimeter(15, 25, out double area, out double perimeter);
        Console.WriteLine($"The area is {area}\nThe perimeter is {perimeter}!");
                
    }

    static void IncreaseByOne(ref int number)
    {
        number++;
    }

    static void IncreaseByOne(int number)
    {
        number++;
        //this version is not refencing, so the number is only
        //increased by one within the method, so it does not
        //increase by one outside of the method
    }
    ///This works best when trying to get values for multiple variables
    ///If you use the return keyword, you can only return one variable
    static void IncreaseByOne(ref int numberOne, ref int numberTwo)
    {
        numberOne++;
        numberTwo++;

        //returning a value using an int method would only allow to return
        //One of these variables, or a sum of both, but not both at once
        //so you use a reference keyword 
    }

    //The out keyword can only output the keywords of the method
    //The value of the out keyword type must be defined inside the method
    static void FixCoordinates(ref int x, out int y)
    {
        y = 35; //the out variable must always be declared
        x *= 10;
    }

    //Make a height and width rectangle, and find out its Area and Perimeter
    static void AreaAndParimeter(double height, double width, out double area, out double perimeter)
    {
        area = height * width;
        perimeter = (2 * height) + (2 * width);
    }
}

