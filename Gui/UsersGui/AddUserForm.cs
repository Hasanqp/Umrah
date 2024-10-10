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

namespace Umrah.Gui.UsersGui
{
    public partial class AddUserForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly UsersUserControl _usersUserControl;
        private readonly bool firstStart;
        private Users users;
        private readonly IDataHelper<Users> dataHelper;
        private readonly IDataHelper<UsersRoles> dataHelperUsersRoles;
        private readonly LoadingGui.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private Dictionary<string, bool> ListOfRoles = new Dictionary<string, bool>();


        public AddUserForm(int Id, UsersUserControl _usersUserControl, bool FirstStart)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Users>)ConfigurationObjectManager.GetObject("Users");
            dataHelperUsersRoles = (IDataHelper<UsersRoles>)ConfigurationObjectManager.GetObject("UsersRoles");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new LoadingGui.LoadingForm();
            this.ID = Id;
            this._usersUserControl = _usersUserControl;
            firstStart = FirstStart;
        }

        #region Evints
        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            // Check fields empty
            if (IsFieldsEmpty())
            {
                MessageCollections.ShowFieldsRequired();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (ID == 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageCollections.ShowAddNotification();
                    }
                    else
                    {
                        MessageCollections.ShowUpdateNotification();
                    }
                    if (firstStart == true)
                    {
                        MessageBox.Show("من فضلك, أعد تشغيل البرنامج");
                        Application.Exit();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            // Check fields empty
            if (IsFieldsEmpty())
            {
                MessageCollections.ShowFieldsRequired();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (ID == 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageCollections.ShowAddNotification();
                    }
                    else
                    {
                        MessageCollections.ShowUpdateNotification();
                    }
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
                loadingForm.Hide();
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            loadingForm.Show();
            SetFiledData();
            loadingForm.Hide();
            if (firstStart == true)
            {
                buttonSave.Visible = false;
            }
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (firstStart == true)
            {
                Application.Exit();
            }
        }
        #endregion
        #region Methods

        private async Task<bool> SaveData()
        {
            // Add
            if (ID == 0)
            {
                return await AddData();
            }
            // Edit
            else
            {
                return await EditData();
            }
        }

        private bool IsFieldsEmpty()
        {
            if (textBoxName.Text == string.Empty
                || textBoxUserName.Text == string.Empty
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

        private async Task<bool> AddData()
        {
            // Set Data
            users = new Users
            {
                FullName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Phone = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                AddedDate = DateTime.Now,
            };
            // sumbit
            var result = await dataHelper.AddAsync(users);
            if (result == 1)
            {
                // Add Roles
                var data = await dataHelper.GetAllDataAsync();
                var userid = data.Select(x => x.Id).LastOrDefault();
                SetRoles();
                // Loop into List of Roles

                for (int i = 0; i < ListOfRoles.Count; i++)
                {
                    UsersRoles usersRoles = new UsersRoles
                    {
                        UserId = userid,
                        Key = ListOfRoles.Keys.ToList()[i],
                        Value = ListOfRoles.Values.ToList()[i]
                    };
                    await dataHelperUsersRoles.AddAsync(usersRoles);
                }



                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "اضافة مستخدم",
                    UserName = Properties.Settings.Default.UserName,
                    Details = " تمت اضافة مستخدم" + users.UserName,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                _usersUserControl.LoadData();
                // Toast
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetRoles()
        {
            ListOfRoles.Clear();
            ListOfRoles.Add(checkBoxHome.Name, checkBoxHome.Checked);
            ListOfRoles.Add(checkBoxBuses.Name, checkBoxBuses.Checked);
            ListOfRoles.Add(checkBoxCustomers.Name, checkBoxCustomers.Checked);
            ListOfRoles.Add(checkBoxUsers.Name, checkBoxUsers.Checked);
            ListOfRoles.Add(checkBoxSettings.Name, checkBoxSettings.Checked);
            ListOfRoles.Add(checkBoxSystemRecords.Name, checkBoxSystemRecords.Checked);
            // it is well be Update with new version

            // 
            ListOfRoles.Add(checkBoxAccessBus.Name, checkBoxAccessBus.Checked);
            ListOfRoles.Add(checkBoxAccessCustomer.Name, checkBoxAccessCustomer.Checked);
            ListOfRoles.Add(checkBoxAccessUsers.Name, checkBoxAccessUsers.Checked);
            // it is well be Update with new version

            //
            ListOfRoles.Add(checkBoxAdd.Name, checkBoxAdd.Checked);
            ListOfRoles.Add(checkBoxDelete.Name, checkBoxDelete.Checked);
            ListOfRoles.Add(checkBoxEdit.Name, checkBoxEdit.Checked);
            ListOfRoles.Add(checkBoxExport.Name, checkBoxExport.Checked);
            ListOfRoles.Add(checkBoxSearch.Name, checkBoxSearch.Checked);
        }

        private async Task<bool> EditData()
        {
            // Set Data
            users = new Users
            {
                Id = ID,
                FullName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Phone = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                AddedDate = DateTime.Now,
            };
            // sumbit
            var result = await dataHelper.EditAsync(users);
            if (result == 1)
            {
                // Add Roles
                var rolesData = await dataHelperUsersRoles.GetAllDataAsync();
                var ListOfRolesId = rolesData.Where(x => x.UserId == ID).Select(x => x.Id).ToList();
                // Loop int ListOfRolesId ==> Delete
                for (int j = 0; j < ListOfRolesId.Count; j++)
                {
                    var userid = ListOfRolesId[j];
                    await dataHelperUsersRoles.DeleteAsync(userid);
                }

                SetRoles();

                // Loop into List of Roles

                for (int i = 0; i < ListOfRoles.Count; i++)
                {
                    UsersRoles usersRoles = new UsersRoles
                    {
                        UserId = ID,
                        Key = ListOfRoles.Keys.ToList()[i],
                        Value = ListOfRoles.Values.ToList()[i]
                    };
                    await dataHelperUsersRoles.AddAsync(usersRoles);
                }

                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "تعديل مستخدم",
                    UserName = Properties.Settings.Default.UserName,
                    Details = " تم تعديل مستخدم " + users.UserName,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                // Toast 
                _usersUserControl.LoadData();
                return true;

            }
            else
            {
                return false;
            }
        }

        private async void SetFiledData()
        {
            if (ID > 0)
            {
                // Set Filed
                users = await dataHelper.FindAsync(ID);
                var rolesData = await dataHelperUsersRoles.GetAllDataAsync();
                var ListOfRoles = rolesData.Where(X => X.UserId == ID).Select(x => x.Value).ToList();
                if (users != null)
                {
                    textBoxName.Text = users.FullName;
                    textBoxUserName.Text = users.UserName;
                    textBoxPassword.Text = users.Password;
                    textBoxPhoneNumber.Text = users.Phone;
                    textBoxEmail.Text = users.Email;

                    // Set Current Roles Permissions/Tabs الأذونات / علامات التبويب

                    checkBoxHome.Checked = ListOfRoles[0];
                    checkBoxBuses.Checked = ListOfRoles[1];
                    checkBoxCustomers.Checked = ListOfRoles[2];
                    checkBoxUsers.Checked = ListOfRoles[3];
                    checkBoxSettings.Checked = ListOfRoles[4];
                    checkBoxSystemRecords.Checked = ListOfRoles[5];
                    // it is well be Update with new version

                    // Permissions/Quick Access

                    checkBoxAccessBus.Checked = ListOfRoles[6];
                    checkBoxAccessCustomer.Checked = ListOfRoles[7];
                    checkBoxAccessUsers.Checked = ListOfRoles[9];
                    // it is well be Update with new version
                   
                    // Permissions/Standard operations

                    checkBoxAdd.Checked = ListOfRoles[10];
                    checkBoxDelete.Checked = ListOfRoles[11];
                    checkBoxEdit.Checked = ListOfRoles[12];
                    checkBoxExport.Checked = ListOfRoles[13];
                    checkBoxSearch.Checked = ListOfRoles[14];
                }
                else
                {
                    MessageCollections.ShowErrorServer();
                }
            }
        }
        #endregion
    }
}
