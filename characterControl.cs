//Write a C# Sharp program that takes a character as input and check the input 
//(lowercase) is a vowel, a digit, or any other symbol.

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace csharpDataTypeExcersises
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Type a character to determine what kind of character it is: ");
            char x = Convert.ToChar(Console.ReadLine());
            if ((x == 'a') ||( x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'))
            
                Console.WriteLine("Input character is a wowel.");
            
            else if ((x >= '0') && (x <= '9'))
            
                Console.WriteLine("Input character is a digit");
            
            else
                Console.Write("Input character is neither a wowel nor a digit.");
        }
    }
}