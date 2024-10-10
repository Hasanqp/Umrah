using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Umrah.Code.Helper;
using Umrah.Core;
using Umrah.Data;

namespace Umrah
{
    public partial class StartForm : Form
    {
        private readonly IDataHelper<Users> dataHelper;
        public StartForm()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Users>)ConfigurationObjectManager.GetObject("Users");
        }
        #region Evints
        private void StartForm_Load(object sender, EventArgs e)
        {
            CheckCon();
        }
        #endregion
        #region Methods
        private async void CheckCon()
        {
            labelState.Text = "جاري الاتصال بقاعدة البيانات";
            Umrah.Data.SqlServer.DBContext dB = new Data.SqlServer.DBContext();
            if (await dB.Database.CanConnectAsync())
            {
                var data = await dataHelper.GetAllDataAsync();
                if (data.Count > 0)
                {
                    // Login Form
                    Gui.UsersGui.LoginUserForm loginForm = new Gui.UsersGui.LoginUserForm();
                    loginForm.Show();
                    Hide();
                }
                else
                {
                    // Add Form
                    Gui.UsersGui.AddUserForm addUserForm = new Gui.UsersGui.AddUserForm(0, new Gui.UsersGui.UsersUserControl(), true);
                    addUserForm.Show();
                    Hide();
                }
            }
            else
            {
                Hide();
                var result = MessageBox.Show("هناك خطا في الاتصال في قاعدة البيانات, اضغط نعم لضبط الاتصال و لا للخروج من البرنامج", "خطا في الاتصال",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Gui.SettingsGui.SettingsForm settingsForm = new Gui.SettingsGui.SettingsForm(true);
                    settingsForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }

        }
        #endregion
    }
}
