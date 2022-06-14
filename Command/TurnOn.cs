using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command
{
    // Command
    public class TurnOn : ICommand
    {
        private Bulb mBulb;

        public TurnOn(Bulb bulb)
        {
            mBulb = bulb ?? throw new ArgumentNullException("Bulb", "Bulb cannot be null");
        }

        public void Execute()
        {
            mBulb.TurnOn();
        }

        public void Undo()
        {
            mBulb.TurnOff();
        }

        public void Redo()
        {
            Execute();
        }
    }
}