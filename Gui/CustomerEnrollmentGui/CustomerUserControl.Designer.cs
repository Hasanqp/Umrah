namespace Umrah.Gui.CustomerEnrollmentGui
{
    partial class CustomerUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonAdd = new System.Windows.Forms.Button();
            buttonEdit = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonRefrech = new System.Windows.Forms.Button();
            buttonExport = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            textBoxSearch = new System.Windows.Forms.TextBox();
            buttonSearch = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            pictureBoxWhatsApp = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            pictureBoxGmail = new System.Windows.Forms.PictureBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            comboBoxPageNo = new System.Windows.Forms.ComboBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWhatsApp).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonEdit);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonRefrech);
            flowLayoutPanel1.Controls.Add(buttonExport);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanel1.Size = new System.Drawing.Size(1280, 63);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.Color.White;
            buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAdd.Image = Properties.Resources.plus;
            buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAdd.Location = new System.Drawing.Point(1116, 10);
            buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(149, 42);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "    إضافة";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = System.Drawing.Color.White;
            buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(224, 224, 224);
            buttonEdit.FlatAppearance.BorderSize = 2;
            buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonEdit.Image = Properties.Resources.icons8_edit_32px;
            buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.Location = new System.Drawing.Point(957, 10);
            buttonEdit.Margin = new System.Windows.Forms.Padding(5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new System.Drawing.Size(149, 42);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "    تعديل";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = System.Drawing.Color.White;
            buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            buttonDelete.FlatAppearance.BorderSize = 2;
            buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDelete.Image = Properties.Resources.Delete_32px;
            buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDelete.Location = new System.Drawing.Point(798, 10);
            buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(149, 42);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "    حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefrech
            // 
            buttonRefrech.BackColor = System.Drawing.Color.White;
            buttonRefrech.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            buttonRefrech.FlatAppearance.BorderSize = 2;
            buttonRefrech.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            buttonRefrech.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            buttonRefrech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRefrech.Image = Properties.Resources.icons8_update_32px;
            buttonRefrech.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonRefrech.Location = new System.Drawing.Point(639, 10);
            buttonRefrech.Margin = new System.Windows.Forms.Padding(5);
            buttonRefrech.Name = "buttonRefrech";
            buttonRefrech.Size = new System.Drawing.Size(149, 42);
            buttonRefrech.TabIndex = 3;
            buttonRefrech.Text = "    تحديث";
            buttonRefrech.UseVisualStyleBackColor = false;
            buttonRefrech.Click += buttonRefrech_Click;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = System.Drawing.Color.White;
            buttonExport.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            buttonExport.FlatAppearance.BorderSize = 2;
            buttonExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            buttonExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExport.Image = Properties.Resources.export;
            buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonExport.Location = new System.Drawing.Point(480, 10);
            buttonExport.Margin = new System.Windows.Forms.Padding(5);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new System.Drawing.Size(149, 42);
            buttonExport.TabIndex = 4;
            buttonExport.Text = "    تصدير";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(buttonSearch);
            panel1.Location = new System.Drawing.Point(101, 8);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(371, 44);
            panel1.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            textBoxSearch.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxSearch.Location = new System.Drawing.Point(91, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(280, 44);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            buttonSearch.FlatAppearance.BorderSize = 2;
            buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.ForeColor = System.Drawing.Color.White;
            buttonSearch.Image = Properties.Resources.icons8_search_32px1;
            buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSearch.Location = new System.Drawing.Point(0, 0);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(93, 44);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "   بحث";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBoxWhatsApp);
            panel2.Location = new System.Drawing.Point(57, 10);
            panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(38, 42);
            panel2.TabIndex = 6;
            // 
            // pictureBoxWhatsApp
            // 
            pictureBoxWhatsApp.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxWhatsApp.Image = Properties.Resources.icons8_whatsapp_37;
            pictureBoxWhatsApp.Location = new System.Drawing.Point(0, 0);
            pictureBoxWhatsApp.Name = "pictureBoxWhatsApp";
            pictureBoxWhatsApp.Size = new System.Drawing.Size(38, 42);
            pictureBoxWhatsApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxWhatsApp.TabIndex = 0;
            pictureBoxWhatsApp.TabStop = false;
            pictureBoxWhatsApp.Click += pictureBoxWhatsApp_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBoxGmail);
            panel3.Location = new System.Drawing.Point(13, 10);
            panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(38, 42);
            panel3.TabIndex = 7;
            // 
            // pictureBoxGmail
            // 
            pictureBoxGmail.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxGmail.Image = Properties.Resources.icons8_gmail_37;
            pictureBoxGmail.Location = new System.Drawing.Point(0, 0);
            pictureBoxGmail.Name = "pictureBoxGmail";
            pictureBoxGmail.Size = new System.Drawing.Size(38, 42);
            pictureBoxGmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxGmail.TabIndex = 0;
            pictureBoxGmail.TabStop = false;
            pictureBoxGmail.Click += pictureBoxGmail_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1280, 657);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxPageNo
            // 
            comboBoxPageNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            comboBoxPageNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPageNo.FormattingEnabled = true;
            comboBoxPageNo.Location = new System.Drawing.Point(1173, 686);
            comboBoxPageNo.Name = "comboBoxPageNo";
            comboBoxPageNo.Size = new System.Drawing.Size(104, 31);
            comboBoxPageNo.TabIndex = 2;
            comboBoxPageNo.SelectedIndexChanged += comboBoxPageNo_SelectedIndexChanged;
            // 
            // CustomerUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(comboBoxPageNo);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "CustomerUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1280, 720);
            Load += CustomerUserControl_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWhatsApp).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefrech;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxPageNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxWhatsApp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxGmail;
    }
}
