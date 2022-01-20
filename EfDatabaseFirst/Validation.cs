using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDatabaseFirst
{
    public static class Validation
    {
        public static class ValEnglish
        {
            public static void InvalidPrompt(string field)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid selection, Chose the right Language Option");
                Console.ResetColor();
            }

            public static void InvalidPin(string field)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid {field} Enter the right {field}");
                Console.ResetColor();
            }
        }
    }
}
