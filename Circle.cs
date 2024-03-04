using System;

namespace ShapeSolution
{
    class Circle :Oval
    {
        double radius;
        public Circle(double radius) : base(2 * radius, 2 * radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Parimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
