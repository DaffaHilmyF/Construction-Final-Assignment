namespace TUBES_FINAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TUBES_FINAL.Controller;
    using TUBES_FINAL.Database;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBConn connection = DBConn.CreateConnection;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginController app = new LoginController();
            Application.Run(app.LoginView);
        }
    }
}
