namespace TUBES_FINAL.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TUBES_FINAL.Config;
    using TUBES_FINAL.Database;
    using TUBES_FINAL.Model;
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

        public void CreateAccount(string nama, string nim, string year, string email, string password)
        {
            HandlingConfig.SanitizeInputNotNull(nama, nim, year, email, password);
            HandlingConfig.SanitizeInputIsNumeric(nim, year);
            HandlingConfig.SanitizeInputLengthIsCorrect(nim, 10);
            HandlingConfig.SanitizeInputLengthIsCorrect(year, 4);
            AccountConfig.IsDomainEmailStudentCorrect(email);

            password = AccountConfig.PasswordHashed(password);

            DBStudent.InsertStudent(new StudentModel( nama, email, password, nim, year ));
        }

    }
}
