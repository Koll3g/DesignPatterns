namespace Visitor
{
    public interface IShape
    {
        string AcceptVisitor(IVisitor visitor);
    }
}