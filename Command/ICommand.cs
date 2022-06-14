using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}