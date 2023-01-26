using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTicketMachine
{
    internal class TicketMachine
    {
        static void Main()
        {
            Console.Write("Enter 1 for Cinema or 2 for Theater: ");
            int choice = int.Parse(Console.ReadLine());

            decimal price = choice == 1 ? 35 : 55;
            Console.Write("Are you a student? (y/n): ");
            string isStudent = Console.ReadLine();
            bool student = isStudent.Equals("y", StringComparison.OrdinalIgnoreCase);

            if (student)
            {
                price *= 0.5m;
                Console.WriteLine($"The discounted price is: {price:C}");
            }
            else
            {
                Console.WriteLine($"The non-discounted price is: {price:C}");
            }
        }
    }
}
