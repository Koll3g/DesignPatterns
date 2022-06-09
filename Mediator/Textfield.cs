using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Textfield : Component
    {
        public string TextColor { get; set; }
        
        public Textfield(string textColor)
        {
            TextColor = textColor;
        }
    }
}
