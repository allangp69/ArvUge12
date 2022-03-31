using System;

namespace ArvUge12
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(4);
            Console.WriteLine($"The area of the circle is: {circle.CalcArea()}");

            Console.WriteLine(circle.ToString());

            var cylinder = new Cylinder(4, 2);
            Console.WriteLine($"The volume of the cylinder is: {cylinder.CalcVolume()}");

            Console.WriteLine(cylinder.ToString());

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
