using System;
using System.Text.RegularExpressions;
using FindAreaLibrary.Dto;
using FindAreaLibrary.Figure;

namespace FindAreaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithCircle();

            WorkingWithTriangle();
        }

        private static void WorkingWithCircle()
        {
            Console.WriteLine("Enter the radius");
            var text = Console.ReadLine();

            var match = Regex.Match(text, @"^[\d]*[,]?[\d]+$");

            if (!match.Success)
            {
                Console.WriteLine("Incorrect data specified");

                WorkingWithCircle();
            }

            if (double.TryParse(match.Value, out var radius))
            {
                var circle = new Circle();

                var s = circle.GetArea(new ParamOfCircle { Radius = radius });

                Console.WriteLine($"The area of the circle is {s:##.00}");
            }
        }

        private static void WorkingWithTriangle()
        {
            Console.WriteLine("Enter the sides of the triangle");
            var sides = Console.ReadLine();

            var match = Regex.Matches(sides, @"([\d]*[,]?[\d]+)");

            if (match.Count != 3)
            {
                Console.WriteLine("Incorrect data specified");

                WorkingWithTriangle();
            }

            var split = sides.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (split.Length != 3)
            {
                Console.WriteLine("Incorrect data specified");

                WorkingWithTriangle();
            }

            if (double.TryParse(split[0], out var sideA)
                && double.TryParse(split[1], out var sideB)
                && double.TryParse(split[2], out var sideC))
            {
                var triangle = new Triangle();

                var s = triangle.GetArea(new ParamOfTriangle
                {
                    SideA = sideA,
                    SideB = sideB,
                    SideC = sideC
                });

                Console.WriteLine($"The area of the triangle is {s:##.00}");
            }
        }
    }
}
