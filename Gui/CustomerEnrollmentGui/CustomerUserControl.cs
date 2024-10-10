using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umrah.Code.Helper;
using Umrah.Core;
using Umrah.Data;

namespace Umrah.Gui.CustomerEnrollmentGui
{
    public partial class CustomerUserControl : UserControl
    {
        // Variables
        private readonly IDataHelper<Customers> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private static CustomerUserControl _CustomerUserControl;
        private int RowId;
        private readonly LoadingGui.LoadingForm loadingForm;
        private List<int> IdList = new List<int>();
        private string SearchItem;
        public CustomerUserControl()
        {
            InitializeComponent();
            SetRoles();
            dataHelper = (IDataHelper<Customers>)ConfigurationObjectManager.GetObject("Customers");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigurationObjectManager.GetObject("SystemRecords");
            loadingForm = new LoadingGui.LoadingForm();
            LoadData();
        }

        public static CustomerUserControl Instance()
        {
            return _CustomerUserControl ?? (new CustomerUserControl());
        }

        #region Evints
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(0, this);
            addCustomerForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                var Deleteresult = MessageCollections.ShowDeleteDialog();
                if (Deleteresult)
                {
                    IdList.Clear();
                    SetIdRowForDelete();
                    loadingForm.Show();
                    if (IdList.Count > 0)
                    {
                        for (int i = 0; i < IdList.Count; i++)
                        {
                            RowId = IdList[i];
                            var result = await dataHelper.DeleteAsync(RowId);
                            if (result == 1)
                            {
                                // Save System Records
                                SystemRecords systemRecords = new SystemRecords
                                {
                                    Title = "إجراء حذف",
                                    UserName = Properties.Settings.Default.UserName,
                                    Details = "الباص ذي الرقم التعريفي قد تم حذفه" + RowId.ToString(),
                                    AddedDate = DateTime.Now
                                };
                                await dataHelperSystemRecords.AddAsync(systemRecords);

                                MessageCollections.ShowDeleteNotification();
                            }
                            else
                            {
                                MessageCollections.ShowErrorServer();
                            }
                        }
                        LoadData();
                    }
                    else
                    {
                        MessageCollections.ShowRequiredDeleteRow();
                    }
                }
                loadingForm.Hide();
            }
            else
            {
                MessageCollections.ShowEmptyDataMessage();
            }
        }

        private void buttonRefrech_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            // Convert List of Data to DataTable
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }
            loadingForm.Hide();
            // Re-Set Columns
            DataTable dataTableArranged = SetDataTableColumns(dataTable);
            // Export Data to as sheet Excel
            ExportAsXlsxFile(dataTableArranged);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private async void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            var dataId = data.Select(x => x.Id).ToArray();
            int index = comboBoxPageNo.SelectedIndex;
            int IndexNoOfRow = index * Properties.Settings.Default.DataGridViewRowNo;

            dataGridView1.DataSource = data.Where(x => x.Id >= dataId[IndexNoOfRow]).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
            if (dataGridView1.DataSource == null)
            {
                MessageCollections.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            loadingForm.Hide();
            data.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void pictureBoxWhatsApp_Click(object sender, EventArgs e)
        {
            var url = "https://web.whatsapp.com/";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void pictureBoxGmail_Click(object sender, EventArgs e)
        {
            var url = "https://mail.google.com/mail/";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void CustomerUserControl_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region Methods
        public async void LoadData()
        {
            loadingForm.Show();
            var data = await dataHelper.GetAllDataAsync();
            dataGridView1.DataSource = data.Take(Properties.Settings.Default.DataGridViewRowNo).ToList();

            // Add No of page into combo box
            comboBoxPageNo.Items.Clear();
            double value = (Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.DataGridViewRowNo));
            int NoOfPage = (int)Math.Round(value, MidpointRounding.AwayFromZero);

            for (int i = 0; i < NoOfPage; i++)
            {
                comboBoxPageNo.Items.Add(i);
            }
            //

            if (dataGridView1.DataSource == null)
            {
                MessageCollections.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            loadingForm.Hide();
            data.Clear();
        }

        private void SetColumnsTitle()
        {
            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[1].HeaderText = "إسم المعتمر";
            dataGridView1.Columns[2].HeaderText = "الجنسية";
            dataGridView1.Columns[3].HeaderText = "رقم الجواز أو الإقامة";
            dataGridView1.Columns[4].HeaderText = "رقم الهاتف";
            dataGridView1.Columns[5].HeaderText = "الذهاب";
            dataGridView1.Columns[6].HeaderText = "العودة";
            dataGridView1.Columns[7].HeaderText = "نوع الرحلة";
            dataGridView1.Columns[8].HeaderText = "الموقع";
            dataGridView1.Columns[9].HeaderText = "التفاصيل";
            dataGridView1.Columns[10].HeaderText = "وقت الإضافة";
        }

        private void Edit()
        {
            if (dataGridView1.RowCount > 0)
            {
                // Get Id
                RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                AddCustomerForm addCustomerForm = new AddCustomerForm(RowId, this);
                addCustomerForm.Show();
            }
            else
            {
                MessageCollections.ShowEmptyDataMessage();
            }
        }

        private void SetIdRowForDelete()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    IdList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }

        }

        public async void Search()
        {
            loadingForm.Show();
            SearchItem = textBoxSearch.Text;
            dataGridView1.DataSource = await dataHelper.SearchAsync(SearchItem);
            if (dataGridView1.DataSource == null)
            {
                MessageCollections.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            loadingForm.Hide();
        }

        private DataTable SetDataTableColumns(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "المعرف";
            dataTable.Columns["Name"].SetOrdinal(1);
            dataTable.Columns["Name"].ColumnName = "إسم المعتمر";
            dataTable.Columns["Nationality"].SetOrdinal(2);
            dataTable.Columns["Nationality"].ColumnName = "الجنسية";
            dataTable.Columns["Passport"].SetOrdinal(3);
            dataTable.Columns["Passport"].ColumnName = "رقم الجواز أو الإقامة";
            dataTable.Columns["PhoneNumber"].SetOrdinal(4);
            dataTable.Columns["PhoneNumber"].ColumnName = "رقم الهاتف";
            dataTable.Columns["StartDate"].SetOrdinal(5);
            dataTable.Columns["StartDate"].ColumnName = "العودة";
            dataTable.Columns["FinishDate"].SetOrdinal(6);
            dataTable.Columns["FinishDate"].ColumnName = "الذهاب";
            dataTable.Columns["TripType"].SetOrdinal(7);
            dataTable.Columns["TripType"].ColumnName = "نوع الرحلة";
            dataTable.Columns["Address"].SetOrdinal(8);
            dataTable.Columns["Address"].ColumnName = "الموقع";
            dataTable.Columns["Details"].SetOrdinal(9);
            dataTable.Columns["Details"].ColumnName = "التفاصيل";
            dataTable.Columns["AddedDate"].SetOrdinal(10);
            dataTable.Columns["AddedDate"].ColumnName = "وقت الإضافة";
            return dataTable;
        }

        private void ExportAsXlsxFile(DataTable dataTableArranged)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "تصدير الى ملف اكسل";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel File (.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook xLWorkbook = new XLWorkbook()) // creat Excel File
                    {
                        xLWorkbook.AddWorksheet(dataTableArranged, "Data"); // Add Sheet
                        using (MemoryStream ma = new MemoryStream())
                        {
                            xLWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());
                        }
                    }
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SetRoles()
        {
            if (!UsersRolesManager.GetRole("checkBoxAdd"))
            {
                buttonAdd.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxDelete"))
            {
                buttonDelete.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxEdit"))
            {
                buttonEdit.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxExport"))
            {
                buttonExport.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSearch"))
            {
                buttonSearch.Visible = false;
            }
        }

        #endregion
    }
}
