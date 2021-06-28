
namespace TUBES_FINAL.View
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.B_Login = new System.Windows.Forms.PictureBox();
            this.B_Register_Student = new System.Windows.Forms.PictureBox();
            this.B_Register_Lecturer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.B_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Register_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Register_Lecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailField
            // 
            this.EmailField.BackColor = System.Drawing.SystemColors.Window;
            this.EmailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.Color.Black;
            this.EmailField.Location = new System.Drawing.Point(634, 165);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(320, 20);
            this.EmailField.TabIndex = 0;
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.ForeColor = System.Drawing.Color.Black;
            this.PasswordField.Location = new System.Drawing.Point(634, 243);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(320, 20);
            this.PasswordField.TabIndex = 1;
            // 
            // B_Login
            // 
            this.B_Login.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_Login;
            this.B_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Login.Location = new System.Drawing.Point(855, 292);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(122, 44);
            this.B_Login.TabIndex = 2;
            this.B_Login.TabStop = false;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // B_Register_Student
            // 
            this.B_Register_Student.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_StudentRegister;
            this.B_Register_Student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Register_Student.Location = new System.Drawing.Point(623, 342);
            this.B_Register_Student.Name = "B_Register_Student";
            this.B_Register_Student.Size = new System.Drawing.Size(160, 75);
            this.B_Register_Student.TabIndex = 3;
            this.B_Register_Student.TabStop = false;
            this.B_Register_Student.Click += new System.EventHandler(this.B_Register_Student_Click);
            // 
            // B_Register_Lecturer
            // 
            this.B_Register_Lecturer.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_LecturerRegister;
            this.B_Register_Lecturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Register_Lecturer.Location = new System.Drawing.Point(814, 342);
            this.B_Register_Lecturer.Name = "B_Register_Lecturer";
            this.B_Register_Lecturer.Size = new System.Drawing.Size(160, 75);
            this.B_Register_Lecturer.TabIndex = 4;
            this.B_Register_Lecturer.TabStop = false;
            this.B_Register_Lecturer.Click += new System.EventHandler(this.B_Register_Lecturer_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Background_Login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 531);
            this.Controls.Add(this.B_Register_Lecturer);
            this.Controls.Add(this.B_Register_Student);
            this.Controls.Add(this.B_Login);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.EmailField);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.B_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Register_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Register_Lecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.PictureBox B_Login;
        private System.Windows.Forms.PictureBox B_Register_Student;
        private System.Windows.Forms.PictureBox B_Register_Lecturer;
    }
}