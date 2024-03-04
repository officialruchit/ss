using System;
using UtilityForShape;
namespace ShapeSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|=================================================================|");
            Console.WriteLine("                  OOP CONCEPT : SHAPE");
            Console.WriteLine("|=================================================================|");

            double ractangleLength = InputValidation.GetUserInput("    Please enter the Rectangle Length (in cm):");
            double ractangleWidth = InputValidation.GetUserInput("    Please enter the Rectangle width (in cm):");
            Shape ractangle = new Rectangle(ractangleLength, ractangleWidth);

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            double ovalMajorAxis = InputValidation.GetUserInput("    Please enter the Oval Major Axis (in cm): ");
            double ovalMinorAxis = InputValidation.GetUserInput("    Please enter the Oval Minor Axis (in cm): ");

            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Shape oval = new Oval(ovalMajorAxis, ovalMinorAxis);

            double radius = InputValidation.GetUserInput("    Please enter the circle radius: ");
            Shape circle = new Circle(radius);
            Console.WriteLine("|=================================================================|");
            Console.WriteLine("                        RESULT");
            Console.WriteLine("|=================================================================|");
            Console.WriteLine("    shape name       :    Ractangle");
            Console.WriteLine($"    Serial Number    :    {ractangle.SerialNumber} ");
            Console.WriteLine($"    Area             :    {ractangle.Area()} Sq.cm");
            Console.WriteLine($"    Perimeter        :    {ractangle.Parimeter()} Cm");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("    shape name       :    oval");
            Console.WriteLine($"    Serial Number    :    {oval.SerialNumber}");
            Console.WriteLine($"    Area             :    {oval.Area()} Sq.cm");
            Console.WriteLine($"    Perimeter        :    {oval.Parimeter()} Cm");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("    shape name       :    Circle");
            Console.WriteLine($"    Serial Number    :    {circle.SerialNumber}");
            Console.WriteLine($"    Area             :    {circle.Area()}  Sq.cm");
            Console.WriteLine($"    Perimeter        :    {circle.Parimeter()}  Cm");
            Console.ReadKey();
        }
    }
}
