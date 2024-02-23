//Write a program to demonstrate method overriding (dynamic polymorphism)? 
using System;
namespace Practical10
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

