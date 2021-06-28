namespace TUBES_FINAL.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TUBES_FINAL.View;

    public class RegisterStudentController
    {
        private RegisterStudentView registerView;

        public RegisterStudentController()
        {
            registerView = new RegisterStudentView(this);
            registerView.Show();
        }

        public void BackToLogin()
        {
            registerView.Hide();
            LoginController getForm = new LoginController();
        }

    }
}
