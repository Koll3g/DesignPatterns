using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuilderPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuilderPartA();
            this._builder.BuilderPartB();
            this._builder.BuilderPartC();
        }

    }
}
