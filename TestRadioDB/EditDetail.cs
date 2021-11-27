using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRadioDB.Helpers;
using TestRadioDB.Models;

namespace TestRadioDB
{
    public partial class EditDetail : Form
    {
        private DetailRow currentDetailRow;
        private BindingList<ContainerRow> containersList = new BindingList<ContainerRow>();
        public EditDetail(DetailRow detailRow)
        {
            InitializeComponent();
            this.currentDetailRow = detailRow;
        }

        private void EditDetail_Load(object sender, EventArgs e)
        {
            ContainersHelper.GetInstance().GetContainers();
            BindingListsHelper.ReplaceRange(this.containersList, ContainersHelper.containers);
            this.containerComboBox.DataSource = this.containersList;
            this.containerComboBox.DisplayMember = "Name";
            this.containerNameOrBarcode.Text = this.currentDetailRow.ContainerBarcode;
            this.containerComboBox.SelectedIndex = this.containersList.IndexOf(this.containersList.Where(container => container.ContainerId == this.currentDetailRow.ContainerId).First() ?? this.containersList.First());
            this.detailName.Text = this.currentDetailRow.Name;
            this.amountOfDetails.Value = this.currentDetailRow.Count;
        }

        private void EditDetail_Shown(object sender, EventArgs e)
        {
            this.amountOfDetails.Focus();
        }

        private void containerNameOrBarcode_TextChanged(object sender, EventArgs e)
        {
            var filteredList = new List<ContainerRow>();
            filteredList.AddRange(ContainersHelper.containers.Where(containerItem => containerItem.Barcode == this.containerNameOrBarcode.Text));
            filteredList.AddRange(ContainersHelper.containers.Where(containerItem => containerItem.Name.Contains(this.containerNameOrBarcode.Text)));
            BindingListsHelper.ReplaceRange(this.containersList, filteredList.Select(item => item).Distinct().ToList());
            if (this.containersList.Count > 0)
            {
                this.containerComboBox.SelectedIndex = 0;
            }
            this.SetIsButtonEnabled();
        }

        private void SetIsButtonEnabled()
        {
            var selectedContainer = (ContainerRow)this.containerComboBox.SelectedItem;
            this.saveDetailButton.Enabled = (this.detailName.Text ?? "").Length > 0 && selectedContainer != null && this.amountOfDetails.Value != null && this.amountOfDetails.Value > 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void containerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetIsButtonEnabled();
        }

        private void detailName_TextChanged(object sender, EventArgs e)
        {
            this.SetIsButtonEnabled();
        }

        private void amountOfDetails_ValueChanged(object sender, EventArgs e)
        {
            this.SetIsButtonEnabled();
        }

        private void saveDetailButton_Click(object sender, EventArgs e)
        {
            var amountToAdd = (int)this.amountOfDetails.Value;
            var dbHelperInstance = DBHelper.GetInstance();

            dbHelperInstance.DeleteTopNRows(this.currentDetailRow.Name, this.currentDetailRow.ContainerId, this.currentDetailRow.Count);

            List<DetailRow> addedRows = new List<DetailRow>();
            var newDetailRow = new DetailRow();
            newDetailRow.Name = this.detailName.Text;
            newDetailRow.ContainerId = ((ContainerRow)this.containerComboBox.SelectedItem).ContainerId;
            for (int i = 0; i < amountToAdd; i++)
            {
                addedRows.Add(newDetailRow.CopyDetailRowWihtNewId());
            }
            dbHelperInstance.AddDetails(addedRows);

            MainWindow.RecreateDetailsList();
            this.Close();
        }
    }
}
