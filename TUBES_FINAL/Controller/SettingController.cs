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

    public class SettingController
    {
        private SettingView settingView;
        private string indexUser;

        public SettingController(string index)
        {
            indexUser = index;
            settingView = new SettingView(this);
            settingView.Show();
        }

        private bool FindUserAccount(List<StudentModel> studentList, List<LecturerModel> lecturerList
            , string name, string email, string password)
        {    
            
            HandlingConfig.SanitizeInputNotNull<List<StudentModel>>(studentList);
            HandlingConfig.SanitizeInputNotNull<List<LecturerModel>>(lecturerList);
            
            foreach(var item in studentList)
            { 
                if(item.StudentNIM.CompareTo(indexUser) == 0)
                {
                    StudentModel studentData = new StudentModel();
                    AccountConfig.IsDomainEmailStudentCorrect(email);
                    password = AccountConfig.PasswordHashed(password);

                    studentData.PersonName = name;
                    studentData.PersonEmail = email;
                    studentData.PersonPassword = password;

                    DBStudent.UpdateStudent(indexUser, studentData);

                    return true;
                }
            }

            foreach (var item in lecturerList)
            {
                if (item.LecturerNIDN.CompareTo(indexUser) == 0)
                {
                    LecturerModel lecturerData = new LecturerModel();
                    AccountConfig.IsDomainEmailLecturerCorrect(email);
                    password = AccountConfig.PasswordHashed(password);

                    lecturerData.PersonName = name;
                    lecturerData.PersonEmail = email;
                    lecturerData.PersonPassword = password;

                    DBLecturer.UpdateLecturer(indexUser, lecturerData);

                    return true; 
                }
            }
            return false;
        }

        
        public void UpdateUserData(string nama, string email, string password)
        {
            HandlingConfig.SanitizeInputNotNull(nama, email, password);

            bool isExist = false;
            List<StudentModel> studentList = DBStudent.GetAllStudent();
            List<LecturerModel> lecturerList = DBLecturer.GetAllLecturer();

            isExist = FindUserAccount(studentList, lecturerList, nama, email, password);

            if (isExist != true)
                throw new Exception("Something wrong");
        }

        public void MoveToDashboard()
        {
            settingView.Hide();
            DashboardController getForm = new DashboardController(indexUser);
        }
    }
}
