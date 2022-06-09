using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ColorChangingDialog : IMediator
    {
        private readonly Button colorToRedButton;
        private readonly Button colorToBlueButton;
        private readonly Textfield textfield;

        public ColorChangingDialog(Button colorToRedButton, Button colorToBlueButton, Textfield textfield)
        {
            this.colorToRedButton = colorToRedButton;
            colorToBlueButton.SetMediator(this);

            this.textfield = textfield;
            textfield.SetMediator(this);

            this.colorToBlueButton = colorToBlueButton;
            colorToBlueButton.SetMediator(this);
        }

        public void Notify(Component sender, string eventDescription)
        {
            if(sender == colorToRedButton && eventDescription == "click")
            {
                textfield.TextColor = "red";
            }
            else if(sender == colorToBlueButton && eventDescription == "click")
            {
                textfield.TextColor = "blue";
            }
            else if(eventDescription == "UserFocus")
            {
                //UserFocus - do something with it..
            }
        }
    }
}
