namespace Prototype
{
    public abstract class Shape : IShapePrototype
    {
        public int x;
        public int y;

        public Shape() {
            x = 0;
            y = 0;
        }

        public Shape(Shape source)
        {
            x = source.x;
            y = source.y;
        }

        public abstract IShapePrototype clone();
    }
}