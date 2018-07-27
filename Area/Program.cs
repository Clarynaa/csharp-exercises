using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            float r = float.Parse(Console.ReadLine());
            if (r < 0)
            {
                Console.WriteLine("Error!  Number negative!");
                Console.ReadLine();
            }
            else
            {
                var area = 3.14 * r * r;
                Console.WriteLine("The area of a circle with radius " + r + " is: " + Math.Round(area, 3));
                Console.ReadLine();
            }
        }
    }
}
