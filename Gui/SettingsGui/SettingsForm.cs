using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umrah.Data.SqlServer;
using Umrah.Gui.LoadingGui;

namespace Umrah.Gui.SettingsGui
{
    public partial class SettingsForm : Form
    {
        private LoadingForm loading;
        private readonly bool firstStart;
        public SettingsForm(bool FirstStart)
        {
            InitializeComponent();
            SetGeneralSettings();
            loading = new LoadingForm();
            firstStart = FirstStart;
        }

        #region Evints
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firstStart == true)
            {
                Application.Exit();
            }
        }

        private void SettingsForm_Activated(object sender, EventArgs e)
        {

        }

        private void linkLabelImportImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر شعار المؤسسة";
            openFileDialog.RestoreDirectory = true;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonSaveGeneralSettings_Click(object sender, EventArgs e)
        {
            SaveGeneralSettings();
        }

        private void buttonSaveConString_Click(object sender, EventArgs e)
        {
            var Server = textBoxServer.Text;
            var DataBase = textBoxDataBase.Text;
            var Timeout = numericUpDownTimeout.Value;
            var UserName = textBoxUserName.Text;
            var Password = textBoxPassword.Text;
            if (radioButtonLocalCon.Checked == true)
            {
                // Local Con
                SetLocalCon(Server, DataBase);
            }
            else
            {
                // Network Con
                SetNetWorkCon(Server, DataBase, UserName, Password, Timeout);
            }

            MessageBox.Show("تم حفظ نص الاتصال بنجاح , اعد تشغيل البرنامج لطفا");
            Application.Exit();
        }

        private async void buttonBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "اختر مسار حفظ النسخة الاحتياطية وتجنب اختيار القرص النظام";
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loading.Show();
                string processResult = await Task.Run(() => backUpRestoreHelper.BackUp(folderBrowserDialog.SelectedPath));
                if (processResult == "1")
                {
                    loading.Hide();
                    MessageBox.Show("تم اجراء النسخ الاحتياطي بنجاح");
                }
                else
                {
                    loading.Hide();
                    MessageBox.Show(processResult + "لم نتمكن من اجراء عملية النسخ الاحتياطي بسبب ");
                }
            }
        }

        private async void buttonRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر ملف النسخة الاحتياطية";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Bak File|*.bak";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackUpRestoreHelper backUpRestoreHelper = new BackUpRestoreHelper();
                loading.Show();
                string processResult = await Task.Run(() => backUpRestoreHelper.Restore(openFileDialog.FileName));
                if (processResult == "1")
                {
                    loading.Hide();
                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح");
                }
                else
                {
                    loading.Hide();
                    MessageBox.Show(processResult + "لم نتمكن من استعادة  النسخة الاحتياطية بسبب ");
                }
            }
        }

        private void radioButtonLocalCon_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserName.Enabled = false;
            textBoxPassword.Enabled = false;
            numericUpDownTimeout.Enabled = false;
        }

        private void radioButtonNetworkCon_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserName.Enabled = true;
            textBoxPassword.Enabled = true;
            numericUpDownTimeout.Enabled = true;
        }
        #endregion
        #region Methods
        private void SaveGeneralSettings()
        {
            Properties.Settings.Default.CompanyName = textBoxMasged.Text;
            Properties.Settings.Default.HideNotificationInterval = Convert.ToInt32(numericUpDownNotification.Value);
            Properties.Settings.Default.DataGridViewRowNo = Convert.ToInt32(numericUpDownDataRow.Value);

            // Save Picture
            using (MemoryStream ma = new MemoryStream())
            {
                pictureBoxLogo.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());
            }

            // Save Settings
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات بنجاح");

        }

        private void SetLocalCon(string server, string dataBase)
        {
            var ConString = @"Server=" + server + ";Database=" + dataBase + ";Trusted_Connection=True;";
            Properties.Settings.Default.SqlServerString = ConString;
            // Save Settings
            Properties.Settings.Default.Save();
        }

        private void SetNetWorkCon(string server, string dataBase, string userName, string password, decimal timeout)
        {
            var ConString = @"Server=" + server + ";Database=" + dataBase + ";User Id=" + userName + ";Password=" + password + ";Timeout=" + timeout + "";

            Properties.Settings.Default.SqlServerString = ConString;
            // Save Settings
            Properties.Settings.Default.Save();
        }

        private void SetGeneralSettings()
        {
            textBoxMasged.Text = Properties.Settings.Default.CompanyName;
            numericUpDownNotification.Value = Properties.Settings.Default.HideNotificationInterval;
            numericUpDownDataRow.Value = Properties.Settings.Default.DataGridViewRowNo;

            // Set Picture

            if (Properties.Settings.Default.CompanyLogo != string.Empty) // Check if first open
            {
                var ImageAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo); // Convert string to byte

                using (MemoryStream ma = new MemoryStream(ImageAsByte))
                {
                    pictureBoxLogo.Image = Image.FromStream(ma); // Set picture
                }
            }
        }
        #endregion
    }
}
