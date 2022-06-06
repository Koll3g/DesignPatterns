using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public int width;
        public int height;

        public Rectangle(Rectangle source) : base(source) {
            width = source.width;
            height = source.height;
        }

        public override IShapePrototype clone()
        {
            return new Rectangle(this);
        }
    }
}
