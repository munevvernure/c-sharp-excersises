//Write a C# Sharp program to accept two integers and check whether they are equal or not. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number 1: ");
            int n1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine(n1 + " and " + n2 + " are equal ");
            }
            else
                Console.WriteLine(n1 + " and " + n2 + " are not equal ");
        }
    }
}
