using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_pad_with_attempts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            string correctCode = "13579";
            int attempts = 0;
            int maxAttempts = 5;

            while (continueProgram && attempts < maxAttempts)
            {
                Console.WriteLine("Hello, Please enter key code: ");
                string code = Console.ReadLine();
                attempts++;

                if (code == correctCode)
                {
                    continueProgram = false;
                    Console.WriteLine("Welcome!");
                }
            }

            if (attempts == maxAttempts && continueProgram)
            {
                Console.WriteLine("Too many incorrect attempts. Goodbye!");
            }
        }
    }
}




