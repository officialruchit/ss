using System;

namespace ShapeSolution
{
    class Oval : Shape
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }
        public Oval(double majorAxis, double minorAxis) : base(majorAxis, minorAxis)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }
        public override double Area()
        {
            return Math.PI * MajorAxis/2 * MinorAxis/2;
        }
        public override double Parimeter()
        {
            return Math.PI * (3 * (MajorAxis + MinorAxis) - Math.Sqrt((3 * MajorAxis + MinorAxis) * (MajorAxis + 3 * MinorAxis)))/2;
        }
        public override string ClassName()
        {
            return "Oval";
        }
    }
}
