namespace Visitor
{
    public class Rectangle : IShape
    {
        private readonly double _x;
        private readonly double _y;
        public Rectangle(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public double X { get { return _x; } }
        public double Y { get { return _y; } }

        public string AcceptVisitor(IVisitor visitor)
        {
            return visitor.VisitRectangle(this);
        }
    }
}