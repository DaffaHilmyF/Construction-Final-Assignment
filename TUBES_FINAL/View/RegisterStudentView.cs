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

    public partial class RegisterStudentView : Form
    {
        private RegisterStudentController controller;
        public RegisterStudentView(RegisterStudentController register)
        {
            InitializeComponent();
            controller = register;
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            try
            {
                controller.BackToLogin();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void B_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                controller.CreateAccount(
                        NameField.Text,
                        NIMField.Text,
                        YearField.Text,
                        EmailField.Text,
                        PasswordField.Text    
                    );
                MessageBox.Show("Sucess");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }
    }
}
