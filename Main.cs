using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umrah.Code.Helper;

namespace Umrah
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);
            SetRoles();
            // Load Home Page
            pageManager.LoadPage(Gui.HomeGui.HomeUserControl.Instance());
        }

        #region Evints
        private void buttonHome_Click(object sender, EventArgs e)
        {
            // Load Home Page
            pageManager.LoadPage(Gui.HomeGui.HomeUserControl.Instance());
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            // Load Users Page 
            pageManager.LoadPage(Gui.UsersGui.UsersUserControl.Instance());
        }

        private void buttonBusEnrollment_Click(object sender, EventArgs e)
        {
            // Load Buses Page
            pageManager.LoadPage(Gui.BusEnrollmentGui.BusUserControl.Instance());
        }

        private void buttonSystemRecords_Click(object sender, EventArgs e)
        {
            // Load SystemRecords Page
            pageManager.LoadPage(Gui.SystemRecordsGui.SystemRecordsUserControl.Instance());
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Gui.SettingsGui.SettingsForm settingsForm = new Gui.SettingsGui.SettingsForm(false);
            settingsForm.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            Gui.AboutGui.About aboutForm = new Gui.AboutGui.About();
            aboutForm.Show();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            // Load Buses Page
            pageManager.LoadPage(Gui.CustomerEnrollmentGui.CustomerUserControl.Instance());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Gui.UsersGui.LoginUserForm loginForm = new Gui.UsersGui.LoginUserForm();
            loginForm.Show();
            Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Methods
        private void SetRoles()
        {
            if (!UsersRolesManager.GetRole("checkBoxHome"))
            {
                buttonHome.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxBuses"))
            {
                buttonBusEnrollment.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxCustomers"))
            {
                buttonCustomers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxUsers"))
            {
                buttonUsers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSettings"))
            {
                buttonSettings.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSystemRecords"))
            {
                buttonSystemRecords.Visible = false;
            }
            // it is well be Update with new version
        }
        #endregion
    }
}
