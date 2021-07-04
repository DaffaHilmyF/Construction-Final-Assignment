namespace TUBES_FINAL.Controller
{
    using System;
    using System.Collections.Generic;
    using TUBES_FINAL.Config;
    using TUBES_FINAL.Database;
    using TUBES_FINAL.Model;
    using TUBES_FINAL.View;

    public class LoginController
    {
        private bool isExist = false;
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
            RegisterLecturerController getForm = new RegisterLecturerController();
        }

        private bool FindUserAccount(List<StudentModel> studentList, List<LecturerModel> lecturerList,
            string email, string password)
        {
            HandlingConfig.SanitizeInputNotNull<List<LecturerModel>>(lecturerList);
            HandlingConfig.SanitizeInputNotNull<List<StudentModel>>(studentList);
            
            string indexUser;

            foreach (var item in lecturerList)
            {
                if (item.PersonEmail.CompareTo(email) == 0)
                {
                    if (AccountConfig.IsPasswordCorrect(password, item.PersonPassword))
                    {
                        
                        indexUser = item.LecturerNIDN;
                        LoginView.Hide();
                        DashboardController getForm = new DashboardController(indexUser);
                        return true;
                    }


                }
            }

            foreach (var item in studentList)
            {
                if (item.PersonEmail.CompareTo(email) == 0)
                {
                    if (AccountConfig.IsPasswordCorrect(password, item.PersonPassword))
                    {
                        isExist = true;
                        indexUser = item.StudentNIM;
                        LoginView.Hide();
                        DashboardController getForm = new DashboardController(indexUser);
                        return true;
                    }

                }
            }

            return false;
        }

        public void MoveToDashboard(string email, string password)
        {
            HandlingConfig.SanitizeInputNotNull(email, password);

            List<LecturerModel> lecturerList = DBLecturer.GetAllLecturer();
            List<StudentModel> studentList = DBStudent.GetAllStudent();

            isExist = FindUserAccount(studentList, lecturerList, email, password);

            if (isExist != true)
                throw new Exception("Account not found");
        }

    }
}
