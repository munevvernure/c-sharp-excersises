//Write a C# Sharp program that takes two numbers as input
//and perform an operation (+,-,*,x,/)on them and 
//displays the result of that operation. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpDataTypeExcersises
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Type the first to do the neccesary operations: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second number to do the neccesary operations: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose one of the given operations: 1)+,2)-,3)/,4)x");
           
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Sum of number 1 and Number 2 is: " + number1 + number2);
                    break;
               case 2:
                    Console.WriteLine("Subtraction of number1 and number 2 is: "  +( number1 - number2));
                    break;
               case 3:
                     Console.WriteLine("Ratio of number1 and number 2 is: " + number1 / number2);
                     break;
                case 4:
                    Console.WriteLine("Product of number 1 and number 2 is: " + number1 * number2);
                    break;
                default:
                    Console.WriteLine("Your selection is not valid.Please try again!");
                    break;
            }
            Console.ReadLine();
        }
    }
}