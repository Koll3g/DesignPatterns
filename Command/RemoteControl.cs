using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command
{
    // Invoker
    public class RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }
    }
}