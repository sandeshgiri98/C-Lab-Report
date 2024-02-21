//4)Create a class Calculate which contains data member num1 and num2 both in integer and methods setCalc() to set the data,
//calcSum() that calculate the sum of num1 and num2 and display the result, calcMulti() that calculate the multiplication of
//num1 and num2 and returns the result, calcDifference that calculate the difference between num1 and num2 and display the result.
//Now, create some instance of Calculate and invoke all the methods. 
using System;

namespace Practical4
{
    class Calculate
    {
        private int num1;
        private int num2;

        public void setCalc(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public void calcSum()
        {
            int sum = num1 + num2;
            Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
        }

        public int calcMulti()
        {
            return num1 * num2;
        }

        public void calcDifference()
        {
            int difference = num1 - num2;
            Console.WriteLine($"Difference between {num1} and {num2} is: {difference}");
        }
    }

    class Solution4
    {
        static void Main(string[] args)
        {
            
        }
    }
}
