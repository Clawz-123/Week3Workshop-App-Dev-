using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week3Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //NullOperations NullOperators = new NullOperations();



            ////OddevenFinder oddevenFinder = new OddevenFinder();  
            ////Console.WriteLine("Addition: " + calculator.Add(5, 3));
            ////Console.WriteLine("Subtraction: " + calculator.Subtract(5, 3));
            ////Console.WriteLine("Multiplication: " + calculator.Multiply(5, 3));
            ////Console.WriteLine("Division: " + calculator.Divide(5, 3));

            //Console.WriteLine("Odd or Even (5): " + calculator.FindOddEven(5));

            //calling the method to perform null checks
            //NullOperators.PerformNullChecks();



            //// Task 3: If else and Switch 
            //Console.WriteLine("Please, enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //
            //if (age < 13)
            //{
            //    Console.WriteLine("Child");
            //}
            //else if (age >= 13 && age <= 19)
            //{
            //    Console.WriteLine("Teenager");
            //}
            //else
            //{
            //    Console.WriteLine("Adult");
            //}


            //// Task 4: If else and Switch 
            //Console.Write("Please, enter a day number (1-7): ");
            //int dayNumber = int.Parse(Console.ReadLine());

            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;
            //}


            ////Task 5 : Loops
            ////Printing the sum of numbers from 1 to N
            //Console.Write("Please, enter any number: ");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("The sum of numbers from 1 to " + number + " is: " + sum);


            ////Print Numbers form 1 to 20 using while loop
            ////-Skip multiples of 4
            ////- Stop when number is 15
            //int count = 0;
            //while (count <= 20)
            //{
            //    if (count == 15)
            //    {
            //        break;
            //    }
            //    if (count % 4 == 0)
            //    {
            //        count++;
            //        continue;
            //    }
            //    Console.WriteLine(count);
            //    count++;
            //}



            //    // Program to find the sum of all elements in an array using a foreach loop.
            //    int[] numbers = { 1, 2, 3, 4, 5 };
            //    int totalSum = 0;
            //    foreach (int num in numbers)
            //    {
            //        totalSum += num;
            //    }
            //    Console.WriteLine("The sum of all elements in the array is: " + totalSum);
            //}


            ////Task 6 : Try Catch Finally
            ////Write a program that accepts a number from the user and converts it to an integer.
            //Console.WriteLine("Please enter a number: ");
            //try
            //{
            //    int parsed = int.Parse(Console.ReadLine());
            //    Console.WriteLine("You entered: " + parsed);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid number format");
            //}
            //finally
            //{
            //    Console.WriteLine("Program Executed");
            //}


            // Program that asks for a password.
            Console.Write("Please enter a password: ");
            string password = Console.ReadLine();

            try
            {
                if (password == null || password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

