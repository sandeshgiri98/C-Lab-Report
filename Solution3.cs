//Write a program to demonstrate arithmetic operator overloading and relational operator overloading? 
using System;
namespace Practical3
{
        internal class Solution3
        {
            private int length;
            private int breadth;
            private int height;

            public void SetDimensions(int length, int breadth, int height)
            {
                this.length = length;
                this.breadth = breadth;
                this.height = height;
            }

            public void CalculateVolume()
            {
                Console.WriteLine("The volume is " + (length * breadth * height));
            }

            public static Solution3 operator +(Solution3 box1, Solution3 box2)
            {
                Solution3 result = new Solution3();
                result.length = box1.length + box2.length;
                result.breadth = box1.breadth + box2.breadth;
                result.height = box1.height + box2.height;
                return result;
            }

            public static bool operator ==(Solution3 box1, Solution3 box2)
            {
                return (box1.length == box2.length && box1.breadth == box2.breadth && box1.height == box2.height);
            }

            public static bool operator !=(Solution3 box1, Solution3 box2)
            {
                return !(box1 == box2);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
            }
        }
}

