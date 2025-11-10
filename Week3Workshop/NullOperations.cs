using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Workshop
{
    internal class NullOperations
    {

        public void PerformNullChecks()
        {

            //Ternary Operator
            string userName = null;

            // Using ternary operator to check for null
            string result = (userName == null) ? "Username is not available" : userName;

            // Print the result
            Console.WriteLine(result);

            //Null coalescing operator (??)
            string result2 = userName ?? "Username is not available";
            Console.WriteLine(result2);

            //Null-Coalescing Assignment Operator(??=)
            userName ??= "Pukar Bohara";
            Console.WriteLine($"UserName: {userName}");


        }
    }

}
