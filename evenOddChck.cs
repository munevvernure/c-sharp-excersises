//Write a C# Sharp program that takes two numbers as input and
//returns true or false when both numbers are even or odd

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
            Console.Write("Type number 1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            bool check;
            check = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? true : false;
            Console.WriteLine(check ? "Both numbers are even." : "There is a number odd.");

        }
    }
}