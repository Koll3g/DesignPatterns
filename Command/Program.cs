using System;


namespace Design_Pattern_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulb = new Bulb();

            var turnOn = new TurnOn(bulb);
            var turnOff = new TurnOff(bulb);

            var remote = new RemoteControl();
            remote.Submit(turnOn); // Licht an
            remote.Submit(turnOff); // Licht aus
            Console.ReadLine();

        }
    }
}
