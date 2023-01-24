//Write a C# Sharp program that takes distance and time as input and
//displays the speed in kilometres per hour and miles per hour.
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
            float distance;
            float hour, minute, second;

            Console.Write("Type the distance as meter:");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Type the hour:"); 
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Type the minute:");
            minute = Convert.ToSingle(Console.ReadLine());
            Console.Write("Type the second:");
            second = Convert.ToSingle(Console.ReadLine());

            float timeSec = second + (60 * minute) + (3600 * hour);
            float timeHour = hour + (minute / 60) + (second / 3600);

            float kph = (distance / 1000) / hour;
            float mph = (distance / 1609) / hour;
            float mps = (distance / timeSec);

            Console.WriteLine("Your speed as km/h :" + kph);
            Console.WriteLine("Your speed as mil/h :" + mph);
            Console.WriteLine("Your speed as m/s :" + mps);
        }
    }
}