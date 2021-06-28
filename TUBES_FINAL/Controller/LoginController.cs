namespace TUBES_FINAL.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TUBES_FINAL.View;

    public class LoginController
    {
        public readonly LoginView LoginView;

        public LoginController()
        {
            LoginView = new LoginView(this);
            LoginView.Show();
        }



    }
}
