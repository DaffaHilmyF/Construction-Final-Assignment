namespace TUBES_FINAL.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TUBES_FINAL.Controller;

    public partial class LoginView : Form
    {
        private readonly LoginController controller;
        public LoginView(LoginController login)
        {
            InitializeComponent();
            controller = login;
        }

        private void B_Login_Click(object sender, EventArgs e)
        {

        }

        private void B_Register_Lecturer_Click(object sender, EventArgs e)
        {
            try
            {
                controller.MoveToStudentRegister();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void B_Register_Student_Click(object sender, EventArgs e)
        {
            try
            {
                controller.MoveToStudentRegister();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }
    }
}
