namespace Umrah.Gui.SettingsGui
{
    partial class SettingsForm
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
            linkLabelImportImage = new System.Windows.Forms.LinkLabel();
            buttonSaveGeneralSettings = new System.Windows.Forms.Button();
            numericUpDownDataRow = new System.Windows.Forms.NumericUpDown();
            numericUpDownNotification = new System.Windows.Forms.NumericUpDown();
            textBoxMasged = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            textBoxUserName = new System.Windows.Forms.TextBox();
            textBoxDataBase = new System.Windows.Forms.TextBox();
            textBoxServer = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            buttonSaveConString = new System.Windows.Forms.Button();
            numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            radioButtonNetworkCon = new System.Windows.Forms.RadioButton();
            radioButtonLocalCon = new System.Windows.Forms.RadioButton();
            label9 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            buttonRestore = new System.Windows.Forms.Button();
            buttonBackUp = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabelImportImage);
            groupBox1.Controls.Add(buttonSaveGeneralSettings);
            groupBox1.Controls.Add(numericUpDownDataRow);
            groupBox1.Controls.Add(numericUpDownNotification);
            groupBox1.Controls.Add(textBoxMasged);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBoxLogo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(11, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox1.Size = new System.Drawing.Size(440, 632);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "الإعدادات العامة";
            // 
            // linkLabelImportImage
            // 
            linkLabelImportImage.AutoSize = true;
            linkLabelImportImage.Location = new System.Drawing.Point(209, 479);
            linkLabelImportImage.Name = "linkLabelImportImage";
            linkLabelImportImage.Size = new System.Drawing.Size(43, 20);
            linkLabelImportImage.TabIndex = 3;
            linkLabelImportImage.TabStop = true;
            linkLabelImportImage.Text = "تحميل";
            linkLabelImportImage.LinkClicked += linkLabelImportImage_LinkClicked;
            // 
            // buttonSaveGeneralSettings
            // 
            buttonSaveGeneralSettings.BackColor = System.Drawing.Color.White;
            buttonSaveGeneralSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            buttonSaveGeneralSettings.FlatAppearance.BorderSize = 2;
            buttonSaveGeneralSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            buttonSaveGeneralSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            buttonSaveGeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSaveGeneralSettings.Image = Properties.Resources.icons8_save_32;
            buttonSaveGeneralSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveGeneralSettings.Location = new System.Drawing.Point(29, 572);
            buttonSaveGeneralSettings.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveGeneralSettings.Name = "buttonSaveGeneralSettings";
            buttonSaveGeneralSettings.Size = new System.Drawing.Size(398, 51);
            buttonSaveGeneralSettings.TabIndex = 4;
            buttonSaveGeneralSettings.Text = "     حفظ";
            buttonSaveGeneralSettings.UseVisualStyleBackColor = false;
            buttonSaveGeneralSettings.Click += buttonSaveGeneralSettings_Click;
            // 
            // numericUpDownDataRow
            // 
            numericUpDownDataRow.Location = new System.Drawing.Point(34, 199);
            numericUpDownDataRow.Name = "numericUpDownDataRow";
            numericUpDownDataRow.Size = new System.Drawing.Size(174, 26);
            numericUpDownDataRow.TabIndex = 2;
            numericUpDownDataRow.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // numericUpDownNotification
            // 
            numericUpDownNotification.Location = new System.Drawing.Point(34, 129);
            numericUpDownNotification.Name = "numericUpDownNotification";
            numericUpDownNotification.Size = new System.Drawing.Size(174, 26);
            numericUpDownNotification.TabIndex = 1;
            numericUpDownNotification.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // textBoxMasged
            // 
            textBoxMasged.Location = new System.Drawing.Point(34, 51);
            textBoxMasged.Name = "textBoxMasged";
            textBoxMasged.Size = new System.Drawing.Size(278, 26);
            textBoxMasged.TabIndex = 0;
            textBoxMasged.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(341, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "إسم المسجد";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            pictureBoxLogo.Image = Properties.Resources.umrah_512px_en1;
            pictureBoxLogo.Location = new System.Drawing.Point(131, 323);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(200, 150);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(236, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(198, 20);
            label3.TabIndex = 2;
            label3.Text = "فترة عرض الإشعارات (ثواني) ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(187, 287);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 20);
            label5.TabIndex = 2;
            label5.Text = "شعار المؤسسة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(279, 205);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "عدد البيانات المعروضة";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Location = new System.Drawing.Point(18, 325);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(308, 26);
            textBoxPassword.TabIndex = 11;
            textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Enabled = false;
            textBoxUserName.Location = new System.Drawing.Point(18, 269);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new System.Drawing.Size(308, 26);
            textBoxUserName.TabIndex = 10;
            textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Location = new System.Drawing.Point(20, 163);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBoxDataBase.Size = new System.Drawing.Size(308, 26);
            textBoxDataBase.TabIndex = 8;
            textBoxDataBase.Text = "UmrahDB";
            textBoxDataBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new System.Drawing.Point(20, 117);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBoxServer.Size = new System.Drawing.Size(308, 26);
            textBoxServer.TabIndex = 7;
            textBoxServer.Text = ".\\SQLEXPRESS";
            textBoxServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(374, 272);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(86, 20);
            label10.TabIndex = 2;
            label10.Text = "إسم المستخدم";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(393, 331);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 20);
            label8.TabIndex = 2;
            label8.Text = "كلمة السر";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(369, 166);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(91, 20);
            label6.TabIndex = 2;
            label6.Text = "قاعدة البيانات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(404, 120);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 20);
            label4.TabIndex = 2;
            label4.Text = "السيرفر";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new System.Drawing.Point(456, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(504, 513);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "قواعد البيانات";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonSaveConString);
            groupBox3.Controls.Add(numericUpDownTimeout);
            groupBox3.Controls.Add(textBoxPassword);
            groupBox3.Controls.Add(radioButtonNetworkCon);
            groupBox3.Controls.Add(textBoxUserName);
            groupBox3.Controls.Add(radioButtonLocalCon);
            groupBox3.Controls.Add(textBoxDataBase);
            groupBox3.Controls.Add(textBoxServer);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new System.Drawing.Point(3, 36);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            groupBox3.Size = new System.Drawing.Size(489, 463);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "نص الاتصال";
            // 
            // buttonSaveConString
            // 
            buttonSaveConString.BackColor = System.Drawing.Color.White;
            buttonSaveConString.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            buttonSaveConString.FlatAppearance.BorderSize = 2;
            buttonSaveConString.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            buttonSaveConString.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            buttonSaveConString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSaveConString.Image = Properties.Resources.icons8_save_32_green;
            buttonSaveConString.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveConString.Location = new System.Drawing.Point(35, 404);
            buttonSaveConString.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveConString.Name = "buttonSaveConString";
            buttonSaveConString.Size = new System.Drawing.Size(237, 51);
            buttonSaveConString.TabIndex = 12;
            buttonSaveConString.Text = "     حفظ";
            buttonSaveConString.UseVisualStyleBackColor = false;
            buttonSaveConString.Click += buttonSaveConString_Click;
            // 
            // numericUpDownTimeout
            // 
            numericUpDownTimeout.Enabled = false;
            numericUpDownTimeout.Location = new System.Drawing.Point(20, 220);
            numericUpDownTimeout.Name = "numericUpDownTimeout";
            numericUpDownTimeout.Size = new System.Drawing.Size(306, 26);
            numericUpDownTimeout.TabIndex = 9;
            numericUpDownTimeout.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // radioButtonNetworkCon
            // 
            radioButtonNetworkCon.AutoSize = true;
            radioButtonNetworkCon.Location = new System.Drawing.Point(59, 43);
            radioButtonNetworkCon.Name = "radioButtonNetworkCon";
            radioButtonNetworkCon.Size = new System.Drawing.Size(59, 24);
            radioButtonNetworkCon.TabIndex = 6;
            radioButtonNetworkCon.Text = "شبكي";
            radioButtonNetworkCon.UseVisualStyleBackColor = true;
            radioButtonNetworkCon.CheckedChanged += radioButtonNetworkCon_CheckedChanged;
            // 
            // radioButtonLocalCon
            // 
            radioButtonLocalCon.AutoSize = true;
            radioButtonLocalCon.Checked = true;
            radioButtonLocalCon.Location = new System.Drawing.Point(209, 43);
            radioButtonLocalCon.Name = "radioButtonLocalCon";
            radioButtonLocalCon.Size = new System.Drawing.Size(56, 24);
            radioButtonLocalCon.TabIndex = 5;
            radioButtonLocalCon.TabStop = true;
            radioButtonLocalCon.Text = "محلي";
            radioButtonLocalCon.UseVisualStyleBackColor = true;
            radioButtonLocalCon.CheckedChanged += radioButtonLocalCon_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(327, 222);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(133, 20);
            label9.TabIndex = 2;
            label9.Text = "فترة الاتصال (ثانية)";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(34, 466);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(278, 26);
            textBox1.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(354, 472);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(74, 20);
            label13.TabIndex = 2;
            label13.Text = "رقم الهاتف";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonRestore);
            groupBox4.Controls.Add(buttonBackUp);
            groupBox4.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            groupBox4.Location = new System.Drawing.Point(457, 532);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(500, 113);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "النسخ الاحتياطي والتعيين";
            // 
            // buttonRestore
            // 
            buttonRestore.BackColor = System.Drawing.Color.White;
            buttonRestore.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            buttonRestore.FlatAppearance.BorderSize = 2;
            buttonRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
            buttonRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRestore.ForeColor = System.Drawing.Color.Black;
            buttonRestore.Image = Properties.Resources.icons8_Database_Restore_32px_1;
            buttonRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonRestore.Location = new System.Drawing.Point(8, 53);
            buttonRestore.Margin = new System.Windows.Forms.Padding(5);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new System.Drawing.Size(238, 51);
            buttonRestore.TabIndex = 14;
            buttonRestore.Text = "   استعادة النسخة الاحتياطية";
            buttonRestore.UseVisualStyleBackColor = false;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // buttonBackUp
            // 
            buttonBackUp.BackColor = System.Drawing.Color.White;
            buttonBackUp.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            buttonBackUp.FlatAppearance.BorderSize = 2;
            buttonBackUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            buttonBackUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            buttonBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBackUp.ForeColor = System.Drawing.Color.Black;
            buttonBackUp.Image = Properties.Resources.icons8_data_backup_32px;
            buttonBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonBackUp.Location = new System.Drawing.Point(251, 54);
            buttonBackUp.Margin = new System.Windows.Forms.Padding(5);
            buttonBackUp.Name = "buttonBackUp";
            buttonBackUp.Size = new System.Drawing.Size(238, 51);
            buttonBackUp.TabIndex = 13;
            buttonBackUp.Text = "   النسخ الاحتياطي";
            buttonBackUp.UseVisualStyleBackColor = false;
            buttonBackUp.Click += buttonBackUp_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(972, 650);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            Activated += SettingsForm_Activated;
            FormClosing += SettingsForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeout).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxMasged;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButtonNetworkCon;
        private System.Windows.Forms.RadioButton radioButtonLocalCon;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSaveConString;
        private System.Windows.Forms.Button buttonSaveGeneralSettings;
        private System.Windows.Forms.NumericUpDown numericUpDownDataRow;
        private System.Windows.Forms.NumericUpDown numericUpDownNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelImportImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonBackUp;
    }
}