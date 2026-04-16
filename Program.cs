// !!! does not function as intended
// !!!!! does not function

/*
getting started 1 t/m 5 & assignment 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
*/

/*
assignment 2 

1) Welcome to C#! = string
2) 260 = int/short
3) 56 = int/short
4) 2001.99 = float
5) k1ngd0m = string
*/

/*
assignment 3

int x = 6;
string y = "2";

string result1 = x.ToString() + y; // converts x from int to string
int result2 = x + int.Parse(y); // parse converts y from string to int

Console.WriteLine(result1); // prints string x + string y ("6" + "2" = 62)
Console.WriteLine(result2); // prints int x + int y (6 + 2 = 8)
Console.ReadLine();
*/
/*
int x = 6;
string y = "apple";

string result = x + y;

Console.WriteLine(result);
Console.ReadLine();
*/

/*
assignment 4

int number = 5;
if (number < 1)
{
    Console.WriteLine("The number is out of range!");
    Console.ReadLine();
}
else if (number > 5)
{
    Console.WriteLine("The number is out of range!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("The number is within range!");
    Console.ReadLine();
}
*/
/*
int a = 7, b = 3;
if (a < b)
{
    Console.WriteLine("a is smaller than b");
    Console.ReadLine();
}
else
{
    Console.WriteLine("a is not smaller than b");
    Console.ReadLine();
}
*/

/*
assignment 5

using System;
class Program
{
    static void Main(string[] args)
    {
        double width;
        double height;
        double area;

        Console.WriteLine("Please enter the width:");
        width = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the height:");
        height = double.Parse(Console.ReadLine());

        area = width * height;

        Console.WriteLine("The area of the rectangle is {0} cm", string.Format("{0:F2}", area));
        Console.ReadLine();
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", name);
            Console.ReadLine();
        }
    }
}
*/

/*
assignment 6

using System;
    class Program
{
    static void Main(string[] args)
    {
        int yearofbirth;
        int age;

        Console.WriteLine("Please enter your year of birth:");

        yearofbirth = int.Parse(Console.ReadLine());
        age = DateTime.Now.Year - yearofbirth;

        Console.WriteLine("Your age is {0}", age);
        Console.ReadLine();
    }
}
*/

/*
ConsoleKeyInfo keyName = new ConsoleKeyInfo();
keyName = Console.ReadKey();
Console.WriteLine("Key is {0}, KeyChar is {1}, Modifier is {2}", keyName.Key, keyName.KeyChar, keyName.Modifiers);
Console.ReadLine();
*/
/*
!!! assignment 7 !!!

using System;
class Program
{
    static void Main()
    {
        ConsoleKeyInfo keyName;
        Console.WriteLine("What is my lucky number?");
        keyName = Console.ReadKey();
        
        if (keyName.KeyChar == '5')
        {
            Console.WriteLine("Correct! My lucky number is 5!");
        }
        else if (char.IsDigit(keyName.KeyChar))
        {
            Console.WriteLine("{0} is incorrect", keyName.KeyChar);
        }
        else
        {
            Console.WriteLine("{0} is incorrect. Please key in a number", keyName.KeyChar);
        }
        Console.ReadLine();
    }
}
*/

/*
!!!!! assignment 8 !!!!!

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("What is my lucky word?");
        string input = Console.ReadLine() ?? "";
        string word = input.ToUpper();
        string result = (word == "LUCKY")
            ? "You typed " + word + " and you are... Correct!"
            : "You typed " + word + " and you are... Wrong!";
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
*/

/*
Console.WriteLine("The Switch Test");
string userValue = Console.ReadLine();
switch (userValue)
{
    case "1":
        Console.WriteLine("Case 1");
        Console.ReadLine();
        break;
    case "2":
        Console.WriteLine("Case 2");
        Console.ReadLine();
        break;
    case "3":
        Console.WriteLine("Case 3");
        Console.ReadLine();
        break;
    default:
        Console.WriteLine("Default case");
        Console.ReadLine();
        break;
}
*/
/*
assignment 9

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Drink sizes: 1 = small, 2 = medium, 3 = large");
        Console.Write("Please enter your selection: ");
        string userValue = Console.ReadLine();

        switch (userValue)
        {
            case "1":
            case "small":
                Console.WriteLine("Small selected. Please insert 25 cents.");
                Console.WriteLine("Thank you. Please come again.");
                Console.ReadLine();
                break;
            case "2":
            case "medium":
                Console.WriteLine("Medium selected. Please insert 50 cents.");
                Console.WriteLine("Thank you. Please come again.");
                Console.ReadLine();
                break;
            case "3":
            case "large":
                Console.WriteLine("Large selected. Please insert 75 cents.");
                Console.WriteLine("Thank you. Please come again.");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Invalid. Please select: 1/small, 2/medium, 3/large");
                break;
        }
    }
}
*/

/*
// for loop
for (int a = 0; a < 5; a++)
{
    Console.WriteLine("The a counter is {0}", a);
}
Console.ReadLine();

// while loop
int b = 0;
while (b < 5)
{
    Console.WriteLine("The b counter is {0}", b);
    b++;
}
Console.ReadLine();

// do while loop
int c = 0;
do
{
    Console.WriteLine("The c counter is {0}", c);
    c++;
} while (c < 5);
*/
/*
assignment 10

int i = 1;
while (i < 4)
{
    Console.WriteLine("The counter is {0}", i);
    i++;
}
i = 5;
while (i <= 10)
{
    Console.WriteLine("The counter is {0}", i);
    i++;
}
*/

/*
assignment 11
using System;
class Program
{
    static void Main()
    {
        string userValue = "";

        while (userValue != "3")
        {
            Console.WriteLine("*** MENU ***\n");
            Console.WriteLine("1. Display Menu 1");
            Console.WriteLine("2. Display Menu 2");
            Console.WriteLine("3. Exit\n");

            userValue = Console.ReadLine();

            switch (userValue)
            {
                case "1":
                    Console.WriteLine("Menu 1");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Menu 2");
                    Console.ReadLine();
                    break;
                case "3":
                case "exit":
                    Console.WriteLine("Exit");

                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter: 1, 2 or 3");
                    break;
                
            }
        }
    }
}
*/

/*
int[] num1 = new int[5];

num1[0] = 1;
num1[1] = 2;
num1[2] = 3;
num1[3] = 4;
num1[4] = 5;

int[] num2 = new int[5] { 6, 7, 8, 9, 10 };

int[] num3 = new int[5] { 11, 12, 13, 14, 15 };

for (int i = 0; i < num3.Length; i++)
{
    System.Console.WriteLine(num3[i]);
}
System.Console.ReadLine();

int[] num4 = new int[5] { 16, 17, 18, 19, 20  };

foreach (int element in num4)
{
    Console.WriteLine(element);
}
Console.ReadLine();
*/
/*
assignment 12

using System;
    class Program
{
    static void Main()
    {
        string[] names = new string[5];
        Console.WriteLine("Enter 5 names");
        
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write("Name" + (i + 1) + ": ");
            names[i] = Console.ReadLine();
        }

        Console.WriteLine();

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();
    }
}
*/
/*
assignment 13

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        string input;

        Console.WriteLine("Enter 5 numbers");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("number" + (i + 1) + ": ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out numbers[i]))
            {
                Console.WriteLine("Please enter a number");
                Console.Write("number " + (i + 1) + ": ");
                input = Console.ReadLine();
            }
        }

        Console.WriteLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.ReadLine();
    }
}
*/

/*
assignment 14


int[,] numbers = new int[,] { { 3, 5, 7 }, { 9, 11, 13 }, { 15, 17, 19} };

Console.WriteLine(numbers[1, 2]);

output = 13
*/

/*
assignment 15


class Count
{
    public static int total(int add1, int add2)
    {
        return add1 + add2;
    }

    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        int total = Count.total(num1, num2);
        Console.WriteLine(total);
    }
}
*/

/*
assignment 16


using System;

class Program
{
    static void Main()
    {
        double num1 = GetValidDouble("Please enter number 1");
        double num2 = GetValidDouble("Please enter number 2");

        int choice = GetValidMenuChoice();

        PerformOperation(num1, num2, choice);
    }

    static double GetValidDouble(string message)
    {
        double value;
        Console.WriteLine(message);

        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid. Please enter a number");
        }

        return value;
    }

    static int GetValidMenuChoice()
    {
        int choice;

        while (true)
        {
            Console.WriteLine("\nWhat do you want to do with the numbers?");
            Console.WriteLine("1. Addition & Subtraction");
            Console.WriteLine("2. Addition & Multiplication");
            Console.WriteLine("3. Addition & Division");

            if (int.TryParse(Console.ReadLine(), out choice) && (choice >= 1 && choice <= 3))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid Selection. Please enter 1, 2 or 3");
            }
        }
    }

    static void PerformOperation(double num1, double num2, int choice)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine($"\nAddition:       {num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"Subtraction:    {num1} - {num2} = {num1 - num2}");
                break;

            case 2:
                Console.WriteLine($"\nAddition:       {num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
                break;

            case 3:
                Console.WriteLine($"\nAddition:       {num1} + {num2} = {num1 + num2}");

                if (num2 != 0)
                    Console.WriteLine($"Division:       {num1} / {num2} = {num1 / num2}");
                else
                    Console.WriteLine("Division: Cannot divide by zero");
                break;
        }
    }
}
*/

/*
assignment 17


using System;

class Program
{
    static void Main()
    {
        string[] names = new string[5] { "Merry", "John", "Tim", "Matt", "Jeff" };

        try
        {
            Console.WriteLine("Please enter the length of the array (1, 2, 3, 4 or 5)");
            string input = Console.ReadLine();

            int length = int.Parse(input);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Format Error. Please enter a number. Error Message: {0}", e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Out of range Error. Error Message: {0}", e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("There is an error: {0}", e.Message);
        }

        Console.ReadLine();
    }
}
*/

// ! assignment 18 console app !