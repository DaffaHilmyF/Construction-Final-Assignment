
namespace TUBES_FINAL.View
{
    partial class RegisterStudentView
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
            this.NameField = new System.Windows.Forms.TextBox();
            this.NIMField = new System.Windows.Forms.TextBox();
            this.YearField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.B_Submit = new System.Windows.Forms.PictureBox();
            this.B_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.B_Submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.SystemColors.Window;
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.ForeColor = System.Drawing.Color.Black;
            this.NameField.Location = new System.Drawing.Point(650, 144);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(306, 20);
            this.NameField.TabIndex = 1;
            // 
            // NIMField
            // 
            this.NIMField.BackColor = System.Drawing.SystemColors.Window;
            this.NIMField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NIMField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIMField.ForeColor = System.Drawing.Color.Black;
            this.NIMField.Location = new System.Drawing.Point(650, 220);
            this.NIMField.Name = "NIMField";
            this.NIMField.Size = new System.Drawing.Size(171, 20);
            this.NIMField.TabIndex = 2;
            // 
            // YearField
            // 
            this.YearField.BackColor = System.Drawing.SystemColors.Window;
            this.YearField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearField.ForeColor = System.Drawing.Color.Black;
            this.YearField.Location = new System.Drawing.Point(865, 220);
            this.YearField.Name = "YearField";
            this.YearField.Size = new System.Drawing.Size(95, 20);
            this.YearField.TabIndex = 3;
            // 
            // EmailField
            // 
            this.EmailField.BackColor = System.Drawing.SystemColors.Window;
            this.EmailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.ForeColor = System.Drawing.Color.Black;
            this.EmailField.Location = new System.Drawing.Point(650, 295);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(306, 20);
            this.EmailField.TabIndex = 4;
            // 
            // PasswordField
            // 
            this.PasswordField.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.ForeColor = System.Drawing.Color.Black;
            this.PasswordField.Location = new System.Drawing.Point(650, 371);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(306, 20);
            this.PasswordField.TabIndex = 5;
            // 
            // B_Submit
            // 
            this.B_Submit.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_Submit;
            this.B_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Submit.Location = new System.Drawing.Point(856, 425);
            this.B_Submit.Name = "B_Submit";
            this.B_Submit.Size = new System.Drawing.Size(115, 50);
            this.B_Submit.TabIndex = 6;
            this.B_Submit.TabStop = false;
            // 
            // B_Back
            // 
            this.B_Back.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Button_Back__2_;
            this.B_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Back.Location = new System.Drawing.Point(718, 425);
            this.B_Back.Name = "B_Back";
            this.B_Back.Size = new System.Drawing.Size(115, 50);
            this.B_Back.TabIndex = 7;
            this.B_Back.TabStop = false;
            this.B_Back.Click += new System.EventHandler(this.B_Back_Click);
            // 
            // RegisterStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TUBES_FINAL.Properties.Resources.Background_RegisterStudent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 531);
            this.Controls.Add(this.B_Back);
            this.Controls.Add(this.B_Submit);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.YearField);
            this.Controls.Add(this.NIMField);
            this.Controls.Add(this.NameField);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterStudentView";
            this.Text = "RegisterStudentView";
            ((System.ComponentModel.ISupportInitialize)(this.B_Submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox NIMField;
        private System.Windows.Forms.TextBox YearField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.PictureBox B_Submit;
        private System.Windows.Forms.PictureBox B_Back;
    }
}