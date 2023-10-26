using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDOS
{
    internal static class Input
    {
        internal static string Password()
        {
            string input = string.Empty;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(string.Empty);
                    return input;
                }
                Console.Write("*");
                input += key.KeyChar;
            }
        }

        internal static string Lower()
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }
            return input.ToLower();
        }
    }
}
