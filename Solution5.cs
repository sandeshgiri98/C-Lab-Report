// Create a class Number having instance variable x and y both in integer, default constructor that set the value of x and y to 0,
//  parameterized constructor that sets the value of x and y, method findOdd() that calculates the even no. occurring between
//  x and y and display the result, findEven() that calculates 
//the odd no. occurring between x and y and display the results. Now, create some instance of Number and invoke all the methods.  

using System;
namespace Practical5
{

class Number
{
    private int x;
    private int y;

    public Number()
    {
        x = 0;
        y = 0;
    }

    public Number(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void findOdd()
    {
        Console.WriteLine("Even numbers between " + x + " and " + y + ":");
        for (int i = x; i <= y; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void findEven()
    {
        Console.WriteLine("Odd numbers between " + x + " and " + y + ":");
        for (int i = x; i <= y; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
