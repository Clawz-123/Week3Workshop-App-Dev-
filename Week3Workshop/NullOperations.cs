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
            // Declare username and assign null
            string? username = null;

            // 1) Ternary operator (? :)
            Console.WriteLine("Ternary check: " + (username == null ? "Username is not available" : username));

            // 2) Null-coalescing operator (??)
            Console.WriteLine("Null-coalescing check: " + (username ?? "Username is not available"));

            // 3) Null-coalescing assignment operator (??=)
            username ??= "GuestUser";

            // Print the updated value after ??= assignment
            Console.WriteLine("After ??= assignment: " + username);
        }
    }
}
