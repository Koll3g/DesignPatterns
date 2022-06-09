using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class AuthenticationDialog : IMediator
    {
        public string Title { get; set; }
        private readonly Checkbox loginOrRegisterChkBx;
        private readonly Button okButton;
        private readonly Textbox loginUsername;

        public AuthenticationDialog(Button okButton, Checkbox loginOrRegisterChkBx, Textbox loginUsername)
        {
            this.okButton = okButton;
            okButton.SetMediator(this);

            this.loginUsername = loginUsername;
            loginUsername.SetMediator(this);

            this.loginOrRegisterChkBx = loginOrRegisterChkBx;
            loginOrRegisterChkBx.SetMediator(this);
        }

        public void Notify(Component sender, string eventDescription)
        {
            if(sender == loginOrRegisterChkBx && eventDescription == "check")
            {
                if (loginOrRegisterChkBx.Checked)
                {
                    Title = "Login";
                }
                else
                {
                    Title = "Register";
                }
            }
            if(sender == okButton && eventDescription == "click")
            {
                //Do something - the button was pressed!
            }

            //Implement logic for authentication dialog here
        }
    }
}
