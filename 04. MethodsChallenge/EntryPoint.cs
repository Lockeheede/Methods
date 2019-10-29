using System;
//Note to self, learn how to take old code and re-work them.
class EntryPoint
{
    static void Main()
    {
        Console.WriteLine(ArrangeNumbers(36, 36, 27));//This method uses a string to arrange the given integers 
        //Using info from the nestedloop tutorial, I have devised a way to make a method instead.
        //See? Now each time I need to do that operation, I can simply use this ArrangeNumbers method
        
        
        int[] sortNumbers = SortNumbers(777, 247, 214);//But, if you need to put the integers in an array using methods
        //you need to do it differently. Check the difference between the ArrangeNumbers and SortNumbers methods
        

        foreach (var item in sortNumbers)//foreach is a good loop to use when using an array method
        {
            Console.WriteLine(item);
        }
        
    }

static string ArrangeNumbers(int a, int b, int c)
{
    string sorted = string.Empty;



        if (a > b && a > c)

        {

            sorted = a + " ";

            if (b > c)
            {
                sorted = sorted + b + " " + c;


            }

            else
            {
                sorted = sorted + c + " " + b;
            }
        }
        else if (b > a && b > c)

        {

            sorted = b + " ";

            if (a > c)
            {
                sorted = sorted + a + " " + c;

            }
            else
            {
                sorted = sorted + c + " " + a;

            }

        }

        else if (c > a && c > b)

        {

            sorted = c + " ";

            if (a > b)
            {
                sorted = sorted + a + " " + b;

            }

            else
            {
                sorted = sorted + b + " " + a;
               
            }
        }
        else if (a == b || a == c || b == c)

        {

            Console.WriteLine("At least one of these numbers are equal, so I can't sort them!");



        }

        return sorted;
    }
   static int[] SortNumbers(int a, int b, int c)
    {
        int[] SortedThreeNumbers = new int[3];



        if (a > b && a > c)

        {

            SortedThreeNumbers[0] = a;

            if (b > c)
            {
                SortedThreeNumbers[1] = b;
                SortedThreeNumbers[2] = c;


            }

            else
            {
                SortedThreeNumbers[1] = c; 
                SortedThreeNumbers[2] = b;
            }
        }
        else if (b > a && b > c)

        {

            SortedThreeNumbers[0] = b;

            if (a > c)
            {
                SortedThreeNumbers[1] = a;
                SortedThreeNumbers[2] = c;

            }
            else
            {
                SortedThreeNumbers[1] = c;
                SortedThreeNumbers[2] = a;

            }

        }

        else if (c > a && c > b)

        {

            SortedThreeNumbers[0] = c;

            if (a > b)
            {
                SortedThreeNumbers[1] = a;
                SortedThreeNumbers[2] = b;
            }

            else
            {
                SortedThreeNumbers[1] = b;
                SortedThreeNumbers[2] = a;

            }
        }
        else if (a == b || a == c || b == c)

        {

            Console.WriteLine("At least one of these numbers are equal, so I can't sort them!");



        }

        return SortedThreeNumbers;
    }


}

