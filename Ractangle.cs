namespace ShapeSolution
{
    class Rectangle : Shape
    {
        public Rectangle(double length, double width) : base(length, width) { }
        public override double Area()
        {
            return XAxis * YAxis;
        }
        public override double Parimeter()
        {
            return 2 * (XAxis + YAxis);
        }
        public override string ClassName()
        {
            return "Rectangle";
        }
    }
}