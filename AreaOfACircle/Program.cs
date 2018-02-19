using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double area;

            do
            {
                Console.WriteLine("Enter a radius:");
                r = double.Parse(Console.ReadLine());
                if (r < 0)
                {
                    Console.WriteLine("Please enter a positive number!");
                }
            } while (r < 0);

            area = 3.14 * r * r;
            Console.WriteLine("The area of a circle with radius " + r + " is: " + area);
            Console.ReadLine();
        }
    }
}