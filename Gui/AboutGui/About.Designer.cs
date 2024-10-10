namespace Umrah.Gui.AboutGui
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            logoPictureBox = new System.Windows.Forms.PictureBox();
            labelProductName = new System.Windows.Forms.Label();
            labelVersion = new System.Windows.Forms.Label();
            labelCopyright = new System.Windows.Forms.Label();
            labelCompanyName = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            okButton = new System.Windows.Forms.Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.7886162F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.2113838F));
            tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
            tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
            tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
            tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
            tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
            tableLayoutPanel.Controls.Add(okButton, 1, 5);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(16, 14);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel.Size = new System.Drawing.Size(615, 335);
            tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            logoPictureBox.Image = Properties.Resources.pngtree_makkah_islamic_image_15802072;
            logoPictureBox.Location = new System.Drawing.Point(365, 5);
            logoPictureBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            logoPictureBox.Name = "logoPictureBox";
            tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
            logoPictureBox.Size = new System.Drawing.Size(244, 325);
            logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 12;
            logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            labelProductName.Location = new System.Drawing.Point(6, 0);
            labelProductName.Margin = new System.Windows.Forms.Padding(11, 0, 6, 0);
            labelProductName.MaximumSize = new System.Drawing.Size(0, 30);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new System.Drawing.Size(342, 30);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "إسم البرنامج :";
            labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            labelVersion.Location = new System.Drawing.Point(6, 33);
            labelVersion.Margin = new System.Windows.Forms.Padding(11, 0, 6, 0);
            labelVersion.MaximumSize = new System.Drawing.Size(0, 30);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(342, 30);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "النسخة :";
            labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            labelCopyright.Location = new System.Drawing.Point(6, 66);
            labelCopyright.Margin = new System.Windows.Forms.Padding(11, 0, 6, 0);
            labelCopyright.MaximumSize = new System.Drawing.Size(0, 30);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new System.Drawing.Size(342, 30);
            labelCopyright.TabIndex = 21;
            labelCopyright.Text = "الحقوق : ";
            labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            labelCompanyName.Location = new System.Drawing.Point(6, 99);
            labelCompanyName.Margin = new System.Windows.Forms.Padding(11, 0, 6, 0);
            labelCompanyName.MaximumSize = new System.Drawing.Size(0, 30);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(342, 30);
            labelCompanyName.TabIndex = 22;
            labelCompanyName.Text = "إسم المؤسسة : ";
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxDescription.Location = new System.Drawing.Point(6, 137);
            textBoxDescription.Margin = new System.Windows.Forms.Padding(11, 5, 6, 5);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxDescription.Size = new System.Drawing.Size(342, 157);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = "الوصف";
            // 
            // okButton
            // 
            okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            okButton.Location = new System.Drawing.Point(6, 304);
            okButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(138, 26);
            okButton.TabIndex = 24;
            okButton.Text = "إغلاق";
            okButton.Click += okButton_Click;
            // 
            // About
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(647, 363);
            Controls.Add(tableLayoutPanel);
            Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
    }
}
