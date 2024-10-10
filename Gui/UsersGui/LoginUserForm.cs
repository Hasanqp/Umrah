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
using Umrah.Core;
using Umrah.Data;
using Umrah.Gui.LoadingGui;

namespace Umrah.Gui.UsersGui
{
    public partial class LoginUserForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly UsersUserControl _usersUserControl;
        private Users users;
        private readonly IDataHelper<Users> dataHelper;
        private readonly IDataHelper<UsersRoles> dataHelperUsersRoles;
        private readonly LoadingGui.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private Dictionary<string, bool> ListOfRoles = new Dictionary<string, bool>();
        public LoginUserForm()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Users>)ConfigurationObjectManager.GetObject("Users");
            dataHelperUsersRoles = (IDataHelper<UsersRoles>)ConfigurationObjectManager.GetObject("UsersRoles");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new LoadingGui.LoadingForm();
        }
        #region Evints
        private void LoginUserForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (IsFiledsEmpty())
            {
                MessageCollections.ShowFieldsRequired();
            }
            else
            {
                var userName = textBoxUserName.Text;
                var password = textBoxPassword.Text;
                loadingForm.Show();
                var UserLoginResult = await Task.Run(() => Login(userName, password));
                if (UserLoginResult == 1)
                {
                    Main main = new Main();
                    main.Show();
                    Hide();
                }
                else if (UserLoginResult == 2)
                {

                    MessageCollections.ShowErrorServer();
                }
                else
                {
                    MessageBox.Show("هناك خطا في معلومات تسجل الدخول");
                }
                loadingForm.Hide();
            }
        }
        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

        }
        #region Methods
        private bool IsFiledsEmpty()
        {
            if (
                 textBoxUserName.Text == string.Empty
                || textBoxPassword.Text == string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int Login(string UserName, string Password)
        {
            try
            {
                // Check
                Users user = dataHelper.GetAllData().Where(x => x.UserName == UserName && x.Password == Password).FirstOrDefault();
                if (user != null)
                {
                    Properties.Settings.Default.UserName = user.FullName;
                    Properties.Settings.Default.Save();
                    // Get Roles
                    var ListRoles = dataHelperUsersRoles.GetAllData().Where(x => x.UserId == user.Id);
                    // Loop into List of Roles and Set Roles
                    UsersRolesManager.ClearRoles();
                    foreach (var item in ListRoles)
                    {
                        UsersRolesManager.Register(item.Key, item.Value);
                    }

                    // Save System Records
                    SystemRecords systemRecords = new SystemRecords
                    {
                        Title = " تسجيل دخول",
                        UserName = Properties.Settings.Default.UserName,
                        Details = "تم تسجيل دخول المستخدم  " + user.UserName,
                        AddedDate = DateTime.Now
                    };
                    dataHelperSystemRecords.Add(systemRecords);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 2;
            }

        }
        #endregion

    }
}
