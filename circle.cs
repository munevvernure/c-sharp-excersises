// Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
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
            double pi = 3.14;
            Console.Write("Type the radius of the circle:");
            int radius = Convert.ToInt32(Console.ReadLine());
            double perimeter = 2 * pi * radius;
            double area = pi * radius * radius;
            Console.WriteLine("Perimeter of the circle is: " + perimeter);
            Console.WriteLine("Area of the circle is: " + area);
            Console.ReadLine();

        }
    }
}