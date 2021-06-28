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


    }
}
