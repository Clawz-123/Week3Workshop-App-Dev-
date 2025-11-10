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
            Console.Write("Please, enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Adult");
            }
        }
    }


}
