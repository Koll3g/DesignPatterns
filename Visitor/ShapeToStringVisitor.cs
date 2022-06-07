namespace Visitor
{
    public class ShapeToStringVisitor : IVisitor
    {
        public string VisitCircle(Circle c)
        {
            return $"Kreis mit Radius = {c.Radius}";
        }

        public string VisitRectangle(Rectangle r)
        {
            return $"Rechteck mit Seitenlängen {r.X} und {r.Y}";
        }
    }
}