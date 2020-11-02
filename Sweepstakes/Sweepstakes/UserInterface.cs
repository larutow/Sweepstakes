using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string GetUSerInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            string answer = Console.ReadLine();

            return answer;
        }

        public static void Display(string value)
        {
            Console.WriteLine(value);
        }
    }
}
