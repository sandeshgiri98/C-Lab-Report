//Write a program to demonstrate different types of constructor     
using System;
namespace Practucal7
{

    class MyClass
    {
        private int x;
        private int y;

        public MyClass()
        {
            x = 0;
            y = 0;
            Console.WriteLine("Default constructor called. x = {0}, y = {1}", x, y);
        }

        public MyClass(int value)
        {
            x = value;
            y = 0;
            Console.WriteLine("Parameterized constructor with one parameter called. x = {0}, y = {1}", x, y);
        }

        public MyClass(int value1, int value2)
        {
            x = value1;
            y = value2;
            Console.WriteLine("Parameterized constructor with two parameters called. x = {0}, y = {1}", x, y);
        }
        public MyClass(MyClass obj)
        {
            x = obj.x;
            y = obj.y;
            Console.WriteLine("Copy constructor called. x = {0}, y = {1}", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
        }
    }
}

