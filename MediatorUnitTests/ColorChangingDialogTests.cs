using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Mediator;

namespace MediatorUnitTests
{
    public class ColorChangingDialogTests
    {
        [Fact]
        public void ButtonToRedClicked_NotifiesMediator_ColorTextboxChanges()
        {
            //Arrange
            Button buttonToRed = new Button();
            Button buttonToBlue = new Button();
            
            string textColor = "green";
            Textfield textfield = new Textfield(textColor);
            
            IMediator colorChangingDialog = new ColorChangingDialog(buttonToRed, buttonToBlue, textfield);

            //Act
            buttonToRed.Click();

            //Assert
            Assert.Equal(textColor, textfield.TextColor);
        }
    }
}
