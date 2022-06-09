using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Mediator;

namespace MediatorUnitTests
{
    public class AuthenticationDialogTests
    {
        [Fact]
        public void CheckboxChecked_NotifiesMediator_TitleChanges()
        {
            //Arrange
            Button okButton = new Button();
            Checkbox checkbox = new Checkbox();
            Textbox textbox = new Textbox();
            
            AuthenticationDialog authenticationDialog = new AuthenticationDialog(okButton, checkbox, textbox);

            //Act
            checkbox.Check();

            //Assert
            Assert.Equal("Login", authenticationDialog.Title);
        }
    }
}
