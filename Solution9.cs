using System;
namespace Practical9
{
    class ParentClass
    {
        protected int baseNumber;

        public ParentClass(int number)
        {
            baseNumber = number;
        }

        public void ShowBaseNumber()
        {
            Console.WriteLine("Base Number: " + baseNumber);
        }
    }
    class ChildClass : ParentClass
    {
        private int derivedNumber;

        public ChildClass(int baseNumber, int derivedNumber) : base(baseNumber)
        {
            this.derivedNumber = derivedNumber;
        }

        public void ShowDerivedNumber()
        {
            Console.WriteLine("Derived Number: " + derivedNumber);
        }

        public void ShowBothNumbers()
        {
            Console.WriteLine("Base Number: " + baseNumber); 
            Console.WriteLine("Derived Number: " + derivedNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

}
