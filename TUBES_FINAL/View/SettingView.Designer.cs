
namespace TUBES_FINAL.View
{
    partial class SettingView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_Submit = new System.Windows.Forms.PictureBox();
            this.B_Back = new System.Windows.Forms.PictureBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TUBES_FINAL.Properties.Resources.ReineP;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // B_Submit
            // 
            this.B_Submit.BackColor = System.Drawing.Color.Transparent;
            this.B_Submit.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_Submit;
            this.B_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Submit.Location = new System.Drawing.Point(828, 352);
            this.B_Submit.Name = "B_Submit";
            this.B_Submit.Size = new System.Drawing.Size(161, 52);
            this.B_Submit.TabIndex = 4;
            this.B_Submit.TabStop = false;
            this.B_Submit.Click += new System.EventHandler(this.B_Submit_Click);
            // 
            // B_Back
            // 
            this.B_Back.BackColor = System.Drawing.Color.Transparent;
            this.B_Back.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_Back__2_;
            this.B_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Back.Location = new System.Drawing.Point(683, 352);
            this.B_Back.Name = "B_Back";
            this.B_Back.Size = new System.Drawing.Size(161, 52);
            this.B_Back.TabIndex = 5;
            this.B_Back.TabStop = false;
            this.B_Back.Click += new System.EventHandler(this.B_Back_Click);
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.SystemColors.Window;
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.ForeColor = System.Drawing.Color.Black;
            this.NameField.Location = new System.Drawing.Point(645, 144);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(306, 20);
            this.NameField.TabIndex = 6;
            // 
            // EmailField
            // 
            this.EmailField.BackColor = System.Drawing.SystemColors.Window;
            this.EmailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.Color.Black;
            this.EmailField.Location = new System.Drawing.Point(645, 222);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(306, 20);
            this.EmailField.TabIndex = 7;
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.ForeColor = System.Drawing.Color.Black;
            this.PasswordField.Location = new System.Drawing.Point(645, 298);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(306, 20);
            this.PasswordField.TabIndex = 8;
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Background_Setting__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 531);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.B_Back);
            this.Controls.Add(this.B_Submit);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingView";
            this.Text = "SettingController";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox B_Submit;
        private System.Windows.Forms.PictureBox B_Back;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PasswordField;
    }
}