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

    public partial class RegisterLecturerView : Form
    {
        private RegisterLecturerController controller;
        public RegisterLecturerView(RegisterLecturerController regist)
        {
            InitializeComponent();
            controller = regist;
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            try
            {
                controller.BackToLogin();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void B_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                controller.CreateAccount(
                        NameField.Text,
                        NIDNField.Text,
                        EmailField.Text,
                        PasswordField.Text
                    );

                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }
    }
}
