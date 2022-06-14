using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command
{
    public class Bulb
    {
        public void TurnOn()
        {
            Console.WriteLine("Bulb has been lit");
        }

        public void TurnOff()
        {
            Console.WriteLine("Darkness!");
        }
    }
}