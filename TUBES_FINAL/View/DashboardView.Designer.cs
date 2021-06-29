
namespace TUBES_FINAL.View
{
    partial class DashboardView
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
            this.L_Welcome = new System.Windows.Forms.Label();
            this.B_Logout = new System.Windows.Forms.PictureBox();
            this.B_Setting = new System.Windows.Forms.PictureBox();
            this.B_Course = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.B_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Welcome
            // 
            this.L_Welcome.AutoSize = true;
            this.L_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.L_Welcome.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.L_Welcome.Location = new System.Drawing.Point(620, 82);
            this.L_Welcome.Name = "L_Welcome";
            this.L_Welcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L_Welcome.Size = new System.Drawing.Size(268, 41);
            this.L_Welcome.TabIndex = 0;
            this.L_Welcome.Text = "Hallo, John Doe";
            // 
            // B_Logout
            // 
            this.B_Logout.BackColor = System.Drawing.Color.Transparent;
            this.B_Logout.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_Logout;
            this.B_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Logout.Location = new System.Drawing.Point(817, 363);
            this.B_Logout.Name = "B_Logout";
            this.B_Logout.Size = new System.Drawing.Size(181, 74);
            this.B_Logout.TabIndex = 3;
            this.B_Logout.TabStop = false;
            this.B_Logout.Click += new System.EventHandler(this.B_Logout_Click);
            // 
            // B_Setting
            // 
            this.B_Setting.BackColor = System.Drawing.Color.Transparent;
            this.B_Setting.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_Setting;
            this.B_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Setting.Location = new System.Drawing.Point(817, 221);
            this.B_Setting.Name = "B_Setting";
            this.B_Setting.Size = new System.Drawing.Size(181, 74);
            this.B_Setting.TabIndex = 4;
            this.B_Setting.TabStop = false;
            this.B_Setting.Click += new System.EventHandler(this.B_Setting_Click);
            // 
            // B_Course
            // 
            this.B_Course.BackColor = System.Drawing.Color.Transparent;
            this.B_Course.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_Course__2_;
            this.B_Course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Course.Location = new System.Drawing.Point(608, 221);
            this.B_Course.Name = "B_Course";
            this.B_Course.Size = new System.Drawing.Size(181, 74);
            this.B_Course.TabIndex = 5;
            this.B_Course.TabStop = false;
            this.B_Course.Click += new System.EventHandler(this.B_Course_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::TUBES_FINAL.Properties.Resources.A_chan;
            this.pictureBox1.Location = new System.Drawing.Point(858, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::TUBES_FINAL.Properties.Resources.Gura;
            this.pictureBox2.Location = new System.Drawing.Point(858, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::TUBES_FINAL.Properties.Resources.Watson;
            this.pictureBox3.Location = new System.Drawing.Point(650, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Background_Dashboard__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 531);
            this.Controls.Add(this.B_Course);
            this.Controls.Add(this.B_Setting);
            this.Controls.Add(this.B_Logout);
            this.Controls.Add(this.L_Welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DashboardView";
            this.Text = "DashboardView";
            ((System.ComponentModel.ISupportInitialize)(this.B_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Welcome;
        private System.Windows.Forms.PictureBox B_Logout;
        private System.Windows.Forms.PictureBox B_Setting;
        private System.Windows.Forms.PictureBox B_Course;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}