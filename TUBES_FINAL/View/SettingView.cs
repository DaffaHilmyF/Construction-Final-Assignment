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

namespace TUBES_FINAL.View
{
    public partial class SettingView : Form
    {
        private SettingController controller;
        public SettingView(SettingController setting)
        {
            InitializeComponent();
            controller = setting;
        }

        private void B_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                controller.UpdateUserData(
                        NameField.Text, 
                        EmailField.Text, 
                        PasswordField.Text
                    );

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            try
            {
                controller.MoveToDashboard();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }
    }
}
