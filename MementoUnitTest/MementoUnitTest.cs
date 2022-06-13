using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Memento;

namespace MementoUnitTest
{
    public class MementoUnitTest
    {
        [Fact]
        public void CreateMemento_NewMemento_MementoIsTrue()
        {
            //Arrange
            Originator o = new Originator()
            {
                State = "True"
            };

            //Act
            Memento.Memento m = o.CreateMemento();

            //Assert
            Assert.Equal(m.State, o.State);
        }

        [Fact]
        public void SetMemento_SetMemento_MementoIsSet()
        {
            //Arrange
            Originator o = new Originator()
            {
                State = "True",
            };

            Memento.Memento m = new Memento.Memento("False");

            //Act
            o.SetMemento(m);

            //Assert
            Assert.Equal(m.State, o.State);

        }
    }
}
