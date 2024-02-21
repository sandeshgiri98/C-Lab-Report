//Write a program to demonstrate class, constructor, properties and method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Solution1
    {
        //properties 
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        //constructor 
        public Solution1(string firstname, string lastname, int age)
        {
            this.FirstName = firstname; this.LastName = lastname; this.Age = age;
        }
        public void Dispaly()
        {
            Console.WriteLine($"Name  {this.FirstName} {this.LastName}");
            Console.WriteLine($"Age: {this.Age} year old");
        }
    }
    class Program1
    {
        public static void Main(string[] args)
        {
        }

    }
}
