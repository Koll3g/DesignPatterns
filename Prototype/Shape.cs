namespace Prototype
{
    public abstract class Shape : IShapePrototype
    {
        public int x;
        public int y;

        public Shape()
        {
            x = 0;
            y = 0;
        }

        public Shape(Shape source)
        {
            x = source.x;
            y = source.y;
        }

        public abstract IShapePrototype Clone();

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Shape p = (Shape)obj;
                return (x == p.x) 
                    && (y == p.y);
            }
        }
    }
}