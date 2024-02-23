using System;
namespace Practical8
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    class BabyDog : Dog
    {
        public void Weep()
        {
            Console.WriteLine("BabyDog is weeping.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
       
    }

}
