//Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1
//(using integer numbers for y , ranging from -5 to +5).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshharpDataTypeExcersises
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Type the value of y to calculate the value of the equation x = y^2 + 2y + 1");
            Console.Write("Value of 'y' is :");
            int y = Convert.ToInt32(Console.ReadLine());
            int x = (y * y) + (2 * y) + 1;
            Console.WriteLine("Result of the given equation is:" + x);
        }
    }
}