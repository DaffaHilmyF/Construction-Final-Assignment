using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUBES_FINAL.Config;
using TUBES_FINAL.Database;
using TUBES_FINAL.Model;
using TUBES_FINAL.View;

namespace TUBES_FINAL.Controller
{
    public class RegisterLecturerController
    {
        private RegisterLecturerView registView;

        public RegisterLecturerController()
        {
            registView = new RegisterLecturerView(this);
            registView.Show();
        }

        public void BackToLogin()
        {
            registView.Hide();
            LoginController getForm = new LoginController();
        }

        internal void CreateAccount(string name, string nidn, string email, string password) 
        {
            HandlingConfig.SanitizeInputNotNull(name, nidn, email, password);
            HandlingConfig.SanitizeInputIsNumeric(nidn);
            HandlingConfig.SanitizeInputLengthIsCorrect(nidn, 10);
            AccountConfig.IsDomainEmailLecturerCorrect(email);

            password = AccountConfig.PasswordHashed(password);

            DBLecturer.InsertLecturer(new LecturerModel(
                        name, email, password, nidn
                ));

        }
    }
}
