namespace Visitor
{
    public interface IVisitor
    {
        string VisitCircle(Circle c);
        string VisitRectangle(Rectangle r);
    }
}