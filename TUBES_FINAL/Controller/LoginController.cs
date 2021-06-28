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

    public class LoginController
    {
        public readonly LoginView LoginView;

        public LoginController()
        {
            LoginView = new LoginView(this);
            LoginView.Show();
        }

        public void MoveToStudentRegister()
        {
            LoginView.Hide();
            RegisterStudentController getForm = new RegisterStudentController();
        }

        public void MoveToLecturerRegister()
        {
            LoginView.Hide();
            
        }

        public void MoveToDashboard(string email, string password)
        {
            HandlingConfig.SanitizeInputNotNull(email, password);

            List<LecturerModel> lecturerList = DBLecturer.GetAllLecturer();
            List<StudentModel> studentList = DBStudent.GetAllStudent();
            string indexUser;

            foreach(var item in lecturerList)
            {
                if(item.PersonEmail.CompareTo(email) == 0)
                {
                    if (AccountConfig.IsPasswordCorrect(item.PersonPassword, password))
                        indexUser = item.PersonID;
                }
            }

            foreach(var item in studentList)
            {
                if (item.PersonEmail.CompareTo(email) == 0)
                {
                    if (AccountConfig.IsPasswordCorrect(item.PersonPassword, password))
                        indexUser = item.PersonID;
                }
            }


            

        }

    }
}
