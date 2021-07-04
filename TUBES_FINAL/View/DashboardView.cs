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

    public partial class DashboardView : Form
    {
        private DashboardController controller;
        public DashboardView(DashboardController dashboard)
        {
            InitializeComponent();
            controller = dashboard;
            L_Welcome.Text = controller.GetUserName;
        }

        private void B_Course_Click(object sender, EventArgs e)
        {

        }

        private void B_Setting_Click(object sender, EventArgs e)
        {
            try
            {
                controller.MoveToSetting();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void B_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                controller.MoveToLogin();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Error.WriteLine(ex.StackTrace);
            }
        }
    }
}
