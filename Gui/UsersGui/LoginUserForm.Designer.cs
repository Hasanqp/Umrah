namespace Umrah.Gui.UsersGui
{
    partial class LoginUserForm
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            textBoxPassword = new System.Windows.Forms.TextBox();
            textBoxUserName = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            buttonLogin = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.images1;
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(528, 551);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المستخدم";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(64, 408);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(312, 26);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new System.Drawing.Point(64, 367);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new System.Drawing.Size(312, 26);
            textBoxUserName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Location = new System.Drawing.Point(410, 411);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(14, 18);
            label7.TabIndex = 5;
            label7.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(398, 370);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 18);
            label5.TabIndex = 6;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(430, 411);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 18);
            label6.TabIndex = 7;
            label6.Text = "كلمة السر";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(418, 370);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 18);
            label4.TabIndex = 8;
            label4.Text = "إسم المستخدم";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            label1.Location = new System.Drawing.Point(202, 313);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(153, 32);
            label1.TabIndex = 1;
            label1.Text = "مرحبا بك مجددا";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Unlock_Login_Page;
            pictureBox1.Location = new System.Drawing.Point(100, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(324, 225);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.images2;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(buttonLogin);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 480);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(528, 71);
            panel1.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = System.Drawing.Color.White;
            buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            buttonLogin.FlatAppearance.BorderSize = 2;
            buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLogin.Image = Properties.Resources.icons8_enter_48;
            buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLogin.Location = new System.Drawing.Point(105, 6);
            buttonLogin.Margin = new System.Windows.Forms.Padding(5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(319, 51);
            buttonLogin.TabIndex = 26;
            buttonLogin.Text = "تسجيل الدخول ";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginUserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(528, 551);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginUserForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "تسجيل دخول";
            FormClosed += LoginUserForm_FormClosed;
            Load += LoginUserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogin;
    }
}