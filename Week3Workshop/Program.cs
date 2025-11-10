namespace Week3Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            ////OddevenFinder oddevenFinder = new OddevenFinder();  
            ////Console.WriteLine("Addition: " + calculator.Add(5, 3));
            ////Console.WriteLine("Subtraction: " + calculator.Subtract(5, 3));
            ////Console.WriteLine("Multiplication: " + calculator.Multiply(5, 3));
            ////Console.WriteLine("Division: " + calculator.Divide(5, 3));

            //Console.WriteLine("Odd or Even (5): " + calculator.FindOddEven(5));

            // Call PerformNullChecks from NullOperations
            //NullOperations nullOps = new NullOperations();
            //nullOps.PerformNullChecks();



            //// Task 3: If else and Switch 
            //Console.Write("Please, enter your age: ");
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


            // Task 4: If else and Switch 
            Console.Write("Please, enter a day number (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }
    }


}
