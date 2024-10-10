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

namespace Umrah.Gui.BusEnrollmentGui
{
    public partial class AddBusForm : Form
    {
        // Variables
        private readonly int ID;
        private readonly BusUserControl busUserControl;
        private Buses buses;
        private readonly IDataHelper<Buses> dataHelper;
        private readonly LoadingGui.LoadingForm loadingForm;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        public AddBusForm(int Id, BusUserControl busUserControl)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Buses>)ConfigurationObjectManager.GetObject("Buses");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");

            loadingForm = new LoadingGui.LoadingForm();
            this.ID = Id;
            this.busUserControl = busUserControl;
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

        private void AddBusForm_Load(object sender, EventArgs e)
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
            if (textBoxBusDriver.Text == string.Empty || textBoxBusNumber.Text == string.Empty)
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
            buses = new Buses
            {
                BusDriver = textBoxBusDriver.Text,
                BusDriverAssistant = textBoxBusDriverAssistant.Text,
                BusNumber = textBoxBusNumber.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            // Sumbit
            var result = await dataHelper.AddAsync(buses);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " اضافة باص",
                    UserName = Properties.Settings.Default.UserName,
                    Details = " تمت إضافة باص ذي الرقم " + buses.BusNumber,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                busUserControl.LoadData();
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
            buses = new Buses
            {
                Id = ID,
                BusDriver = textBoxBusDriver.Text,
                BusDriverAssistant = textBoxBusDriverAssistant.Text,
                BusNumber = textBoxBusNumber.Text,
                Address = textBoxAddress.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            // Sumbit
            var result = await dataHelper.EditAsync(buses);
            if (result == 1)
            {
                // Save System Records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = " تعديل بيانات باص",
                    UserName = Properties.Settings.Default.UserName,
                    Details = " تم تعديل باص ذي الرقم  " + buses.BusNumber,
                    AddedDate = DateTime.Now
                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                // Toast 
                busUserControl.LoadData();
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
                buses = await dataHelper.FindAsync(ID);
                if (buses != null)
                {
                    textBoxBusDriver.Text = buses.BusDriver;
                    textBoxBusDriverAssistant.Text = buses.BusDriverAssistant;
                    textBoxBusNumber.Text = buses.BusNumber;
                    textBoxAddress.Text = buses.Address.ToString();
                    textBoxPhoneNumber.Text = buses.PhoneNumber;
                    richTextBoxDetails.Text = buses.Details;
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
