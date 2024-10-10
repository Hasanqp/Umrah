using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Umrah.Code.Helper;
using Umrah.Core;
using Umrah.Data;
using Umrah.Gui.BusEnrollmentGui;
using Umrah.Gui.CustomerEnrollmentGui;
using Umrah.Gui.UsersGui;

namespace Umrah.Gui.HomeGui
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl _HomeUserControl;

        public HomeUserControl()
        {
            InitializeComponent();
            SetRoles();
            SetGeneralSettings();
            SetHello();
        }

        public static HomeUserControl Instance()
        {
            return _HomeUserControl ?? (new HomeUserControl());
        }

        #region Evints
        private void buttonAddBus_Click(object sender, EventArgs e)
        {
            AddBusForm addBusForm = new AddBusForm(0, new BusUserControl());
            addBusForm.Show();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(0, new CustomerUserControl());
            addCustomerForm.Show();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(0, new UsersUserControl(), false);
            addUserForm.Show();

        }

        // it is a new future!!!, right now IT IS NOT WORKING
        private async void HomeUserControl_Load(object sender, EventArgs e)
        {
            
        }
        #endregion
        #region Methods
        private void SetRoles()
        {
            if (!UsersRolesManager.GetRole("checkBoxAccessBus"))
            {
                buttonAddBus.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessCustomer"))
            {
                buttonAddCustomer.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessUsers"))
            {
                buttonAddUser.Visible = false;
            }
            // it is well be Update with new version
        }

        private void SetGeneralSettings()
        {
            labelCompanyName.Text = Properties.Settings.Default.CompanyName;

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

        private void SetHello()
        {
            labelWellcome.Text = "مرحبا بك " + Properties.Settings.Default.UserName;
        }
        #endregion
    }
}
