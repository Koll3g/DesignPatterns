namespace Visitor
{
    public class Circle : IShape
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Radius { get { return _radius; } }

        public string AcceptVisitor(IVisitor visitor)
        {
            return visitor.VisitCircle(this);
        }
    }
}