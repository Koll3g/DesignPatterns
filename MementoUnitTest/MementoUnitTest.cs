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
            Originator o = new Originator();

            //Act
            o.State = "True";

            //Assert
            Assert.True(o.State == "True");
        }
    }
}
