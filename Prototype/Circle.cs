using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : Shape
    {
        public int radius;

        public Circle() : base()
        {
            radius = 0;
        }

        public Circle(Circle source) : base(source)
        {
            radius = source.radius;
        }

        public override IShapePrototype clone()
        {
            return new Circle(this);
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Circle p = (Circle)obj;
                return (radius == p.radius) 
                    && (base.Equals(p));
            }
        }
    }
}
