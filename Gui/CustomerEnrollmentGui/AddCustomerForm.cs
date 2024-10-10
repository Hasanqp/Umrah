using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umrah.Code.Helper;
using Umrah.Core;
using Umrah.Data;

namespace Umrah.Gui.CustomerEnrollmentGui
{
    public partial class AddCustomerForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly CustomerUserControl customerUserControl;
        private Customers customers;
        private readonly IDataHelper<Customers> dataHelper;
        private readonly LoadingGui.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        public AddCustomerForm(int Id, CustomerUserControl customerUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Customers>)ConfigurationObjectManager.GetObject("Customers");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");

            loadingForm = new LoadingGui.LoadingForm();
            this.ID = Id;
            this.customerUserControl = customerUserControl;
        }

        #region Evints
        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
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
                    Close();
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
                        MessageCollections.ShowAddNotification();
                        this.DialogResult = DialogResult.OK;
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

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            loadingForm.Show();
            SetFieldData();
            loadingForm.Hide();
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
            if (textBoxCustomerName.Text == string.Empty || textBoxCustomerName.Text == string.Empty || textBoxPhoneNumber.Text == string.Empty)
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
            customers = new Customers
            {
                Name = textBoxCustomerName.Text,
                Nationality = textBoxNationality.Text,
                Passport = textBoxPasport.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                StartDate = dateTimePickerStart.Value,
                FinishDate = dateTimePickerFinish.Value,
                TripType = textBoxTripType.Text,
                Address = textBoxAddress.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            // Sumbit
            var result = await dataHelper.AddAsync(customers);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " اضافة معتمر",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تمت إضافة معتمر يحمل إسم " + customers.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                customerUserControl.LoadData();
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<bool> EditData()
        {
            // Set Data
            customers = new Customers
            {
                Id = ID,
                Name = textBoxCustomerName.Text,
                Nationality = textBoxNationality.Text,
                Passport = textBoxPasport.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                StartDate = dateTimePickerStart.Value,
                FinishDate = dateTimePickerFinish.Value,
                TripType = textBoxTripType.Text,
                Address = textBoxAddress.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            // Sumbit
            var result = await dataHelper.EditAsync(customers);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " تعديل بيانات معتمر",
                    UserName = Properties.Settings.Default.UserName,
                    Details = " تم تعديل معتمر يخمل إسم  " + customers.Name,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                // Toast 
                customerUserControl.LoadData();
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void SetFieldData()
        {
            if (ID > 0)
            {
                // Set Field
                customers = await dataHelper.FindAsync(ID);
                if (customers != null)
                {
                    textBoxCustomerName.Text = customers.Name;
                    textBoxNationality.Text = customers.Nationality;
                    textBoxPasport.Text = customers.Passport;
                    textBoxPhoneNumber.Text = customers.PhoneNumber;
                    dateTimePickerStart.Value = customers.StartDate;
                    dateTimePickerFinish.Value = customers.FinishDate;
                    textBoxTripType.Text = customers.TripType;
                    textBoxAddress.Text = customers.Address;
                    richTextBoxDetails.Text = customers.Details;
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
