
using DatabaseConnection;
using DatabaseConnection2;
using DatabaseConnection3;
using DatabaseConnection4;
using DatabaseConnection5;
using DatabaseConnection6;
using DatabaseConnection7;
using Practical1;
using Practical10;
using Practical11;
using Practical12;
using Practical13;
using Practical14;
using Practical15;
using Practical19;
using Practical2;
using Practical20;
using Practical3;
using Practical4;
using Practical5;
using Practical6;
using Practical8;
using Practical9;
using Practucal7;
/*
//This is output of Solution1
Solution1 obj = new Solution1("Sandesh", "Giri", 21);
obj.Dispaly();


//This is output of Solution 2
Console.WriteLine();

Calculator calc = new Calculator();

int result1 = calc.Add(5, 10);
Console.WriteLine("Result of adding two integers: " + result1);

int result2 = calc.Add(5, 10, 15);
Console.WriteLine("Result of adding three integers: " + result2);

double result3 = calc.Add(2.5, 3.5);
Console.WriteLine("Result of adding two doubles: " + result3);
Console.ReadLine();


//This is output of Solution 3
Console.WriteLine();


Solution3 box1 = new Solution3();
Solution3 box2 = new Solution3();

box1.SetDimensions(10, 10, 10);
box2.SetDimensions(10, 10, 10);

box1.CalculateVolume();
box2.CalculateVolume();

Solution3 box3 = box1 + box2;
box3.CalculateVolume();

if (box1 == box2)
{
    Console.WriteLine("box1 is equal to box2");
}
else
{
    Console.WriteLine("box1 is not equal to box2");
}

//This is output of Solution 4
Calculate calc1 = new Calculate();
Calculate calc2 = new Calculate();

calc1.setCalc(10, 5);
calc2.setCalc(8, 3);

calc1.calcSum();
Console.WriteLine($"Multiplication of {calc1.calcMulti()}");

calc2.calcSum();
Console.WriteLine($"Multiplication of {calc2.calcMulti()}");
calc2.calcDifference();


//This is output of Solution 5
Number num1 = new Number(1, 20);
Number num2 = new Number(1, 20);

num1.findOdd();
num2.findEven();
Console.ReadLine();


//This is output of Solution 6
Shape rectangle = new Shape(5.0, 3.0);
rectangle.calcAreaRectangle();

Shape box = new Shape(4.0, 3.0, 2.0);
box.calcVolumeBox();

Console.ReadLine();



//This is output of Solution 7
MyClass obj1 = new MyClass();
MyClass obj2 = new MyClass(5);
MyClass obj3 = new MyClass(10, 20);
MyClass obj4 = new MyClass(obj3);

Console.ReadLine();


//This is output of Solution 8
    Dog dog = new Dog();
    dog.Eat();
    dog.Sleep();
    dog.Bark();

    Console.WriteLine();

    BabyDog babyDog = new BabyDog();
    babyDog.Eat();
    babyDog.Sleep();
    babyDog.Bark();
    babyDog.Weep();

    Console.ReadLine();


//This is output of Solution 9

ChildClass obj = new ChildClass(10, 20);
obj.ShowBaseNumber();
obj.ShowDerivedNumber();
obj.ShowBothNumbers();
Console.ReadLine();


//This is output of Solution 10
Practical10.Shape shape1 = new Practical10.Circle();
Practical10.Shape shape2 = new Practical10.Rectangle();

shape1.Draw();
shape2.Draw();
Console.ReadLine();


//This is output of Solution 11

SalaryInfo emp1 = new SalaryInfo(101, "Sandesh Giri", 'M', "Tokha 10, Pragati Nagar", "Manager", 600000);

Console.WriteLine("Employee Details:");
emp1.DisplayDetails();
Console.WriteLine("\nSalary Details:");
emp1.CalcTax();


//This is output of Solution 12
Solution solution = new Solution(10, 5, 3, 4);
solution.findSum();
solution.findDiff();
Console.WriteLine("Multiplication: " + solution.findMulti());
solution.calcDiv();


//This is output of Solution 13
Solve solve = new Solve();
int sum = solve.add(5, 3);
int difference = solve.diff(5, 3);
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);


//This is output of Solution 14
NumberDemo demo = new NumberDemo();
int num = 5;
Console.WriteLine($"Square of {num}: {demo.Square(num)}");
Console.WriteLine($"Cube of {num}: {demo.Cube(num)}");



//This is output of Solution 15
Circles circle = new Circles(5.0, "Red");
Console.WriteLine("Area of the Circle: " + circle.GetArea());
Console.WriteLine("Color of the Circle: " + circle.GetColor());


//This is output of Solution 16---practical 3
try
{
    Console.WriteLine("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    int result = 10 / num;

    Console.WriteLine("Result of division: " + result);
}
catch (FormatException e)
{
    Console.WriteLine("Please enter a valid number.");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by zero.");
}
catch (Exception e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}
finally
{
    Console.WriteLine("Program execution completed.");
}

//This is output of Solution 17

try
{
    Console.WriteLine("Enter the dividend: ");
    int dividend = int.Parse(Console.ReadLine());

    try
    {
        Console.WriteLine("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        int result = dividend / divisor;
        Console.WriteLine($"Result of division: {result}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid divisor.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred in inner try block: {ex.Message}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Please enter a valid dividend.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred in outer try block: {ex.Message}");
}
finally
{
    Console.WriteLine("Program execution completed.");
}


//This is output of Solution 18
try
{
    Console.WriteLine("Enter a number: ");
    int num = int.Parse(Console.ReadLine());

    int result = 10 / num;

    Console.WriteLine("Result of division: " + result);
}
catch (FormatException e)
{
    Console.WriteLine("Please enter a valid number.");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by zero.");
}
catch (OverflowException e)
{
    Console.WriteLine("Number is too large or too small for an int32.");
}
catch (Exception e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}
finally
{
    Console.WriteLine("Program execution completed.");
}


//This is output of Solution 19
try
{
    throw new CustomException("This is a custom exception demonstration.");
}
catch (CustomException ex)
{
    Console.WriteLine("Custom Exception Caught: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}


//This is output of Database1

CreateTable obj = new CreateTable();
obj.TableCreate();



//This is output of Database2
InsertOperation obj = new InsertOperation();
obj.insert();
Console.ReadKey();


//This is output of Database3
DisplayOperation obj = new DisplayOperation();
obj.display();
Console.ReadKey();


//This is output of Database4
DisplayById obj = new DisplayById();
obj.ShowDetailsById();


//This is output of Database5
UpdateOperation obj = new UpdateOperation();
obj.update();


//This is output of Database6
DeleteById obj = new DeleteById(); obj.Delete();


//This is output of Database7
LoginPortal obj = new LoginPortal();
obj.LoginProtocol();
*/
//This is output of Solution20
EventPublisher publisher = new EventPublisher();
EventSubscriber subscriber = new EventSubscriber();

publisher.RaiseEvent += subscriber.HandleEvent;
publisher.Raise();
publisher.RaiseEvent -= subscriber.HandleEvent;
publisher.Raise();
Console.ReadLine();