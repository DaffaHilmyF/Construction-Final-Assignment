namespace TUBES_FINAL.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TUBES_FINAL.Database;
    using TUBES_FINAL.View;

    public class DashboardController
    {
        private DashboardView dashView;
        private string indexUser;

        public DashboardController(string index)
        {
            indexUser = index;
            dashView = new DashboardView(this);
            dashView.Show();
        }

        public string GetUserName
        {
            get
            {
                string[] userName;

                if (DBLecturer.GetLecturerByNIDN(indexUser) != null)
                {
                    userName = DBLecturer.GetLecturerByNIDN(indexUser).PersonName.Split(new Char[] { ' ' });
                    return "Hello, " + userName[0];
                }

                if (DBStudent.GetStudentByNIM(indexUser) != null)
                {
                    userName = DBStudent.GetStudentByNIM(indexUser).PersonName.Split(new Char[] { ' ' });
                    return "Hello, " + userName[0];
                }

                return "Hello, John Doe";

            }
        }

        public void MoveToSetting()
        {
            dashView.Hide();
            SettingController getForm = new SettingController(indexUser);
        }

        public void MoveToCourse()
        {

        }

        public void MoveToLogin()
        {
            dashView.Hide();
            LoginController getForm = new LoginController();

        }

    }
}
