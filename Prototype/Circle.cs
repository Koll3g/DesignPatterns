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

        public Circle(Circle source) : base(source) {
            radius = source.radius;
        }

        public override IShapePrototype clone()
        {
            return new Circle(this);
        }
    }
}
