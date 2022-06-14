using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainfOfResponsibility
{
    public interface IHandler
    {
        // The Handler interface declares a method for building the chain of
        // handlers. It also declares a method for executing a request.
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
