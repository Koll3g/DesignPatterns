using System;
using Design_Pattern_Command;
using Xunit;

namespace CommandTest
{
    public class UnitTest1
    {
        public class CommandTest
        {
            [Fact]
            public void Check_Objekt_IsNotNull()
            {
                //Arrange
                var bulb1 = new Bulb();
                var remote = new RemoteControl();

                //Act
                var turnOn = new TurnOn(bulb1);
                remote.Submit(turnOn);

                //Assert
                Assert.NotNull(bulb1);
            }
        }
    }
}
