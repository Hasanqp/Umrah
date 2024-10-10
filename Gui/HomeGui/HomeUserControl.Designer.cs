namespace Umrah.Gui.HomeGui
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonAddUser = new System.Windows.Forms.Button();
            buttonAddBus = new System.Windows.Forms.Button();
            buttonAddCustomer = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            labelWellcome = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            labelCompanyName = new System.Windows.Forms.Label();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 323);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1048, 177);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(630, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 33);
            label1.TabIndex = 2;
            label1.Text = "الوصول السريع";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddBus);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Location = new System.Drawing.Point(255, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(638, 96);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "إضافة";
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = System.Drawing.Color.White;
            buttonAddUser.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            buttonAddUser.FlatAppearance.BorderSize = 2;
            buttonAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            buttonAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAddUser.Image = Properties.Resources.icons8_conference_foreground_selected_32px;
            buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new System.Drawing.Point(98, 33);
            buttonAddUser.Margin = new System.Windows.Forms.Padding(5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new System.Drawing.Size(150, 55);
            buttonAddUser.TabIndex = 5;
            buttonAddUser.Text = "    مستخدم";
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonUsers_Click;
            // 
            // buttonAddBus
            // 
            buttonAddBus.BackColor = System.Drawing.Color.White;
            buttonAddBus.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            buttonAddBus.FlatAppearance.BorderSize = 2;
            buttonAddBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            buttonAddBus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            buttonAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAddBus.Image = Properties.Resources.bus;
            buttonAddBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddBus.Location = new System.Drawing.Point(417, 33);
            buttonAddBus.Margin = new System.Windows.Forms.Padding(5);
            buttonAddBus.Name = "buttonAddBus";
            buttonAddBus.Size = new System.Drawing.Size(150, 55);
            buttonAddBus.TabIndex = 6;
            buttonAddBus.Text = "  باص";
            buttonAddBus.UseVisualStyleBackColor = false;
            buttonAddBus.Click += buttonAddBus_Click;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.BackColor = System.Drawing.Color.White;
            buttonAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            buttonAddCustomer.FlatAppearance.BorderSize = 2;
            buttonAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            buttonAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            buttonAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAddCustomer.Image = (System.Drawing.Image)resources.GetObject("buttonAddCustomer.Image");
            buttonAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new System.Drawing.Point(257, 33);
            buttonAddCustomer.Margin = new System.Windows.Forms.Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new System.Drawing.Size(150, 55);
            buttonAddCustomer.TabIndex = 7;
            buttonAddCustomer.Text = "     معتمر";
            buttonAddCustomer.UseVisualStyleBackColor = false;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.umrah_512px_en;
            pictureBox1.Location = new System.Drawing.Point(399, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(69, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelWellcome
            // 
            labelWellcome.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelWellcome.Location = new System.Drawing.Point(25, 32);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new System.Drawing.Size(308, 114);
            labelWellcome.TabIndex = 3;
            labelWellcome.Text = "مرحبا بك مرة أخرى ";
            labelWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Location = new System.Drawing.Point(590, 32);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(455, 114);
            panel2.TabIndex = 4;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Dock = System.Windows.Forms.DockStyle.Right;
            labelCompanyName.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCompanyName.Location = new System.Drawing.Point(6, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(333, 114);
            labelCompanyName.TabIndex = 4;
            labelCompanyName.Text = "أدخل إسم المسجد";
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            pictureBoxLogo.Image = Properties.Resources.umrah_512px_en;
            pictureBoxLogo.Location = new System.Drawing.Point(339, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(116, 114);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel2);
            Controls.Add(labelWellcome);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "HomeUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1048, 500);
            Load += HomeUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddBus;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWellcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
