using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Button : Component
    {        
        public void Click()
        {
            dialog?.Notify(this, "click");
        }
    }
}
