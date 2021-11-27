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
    public partial class AddDetails : Form
    {
        private BindingList<ContainerRow> containersList = new BindingList<ContainerRow>();
        public AddDetails()
        {
            InitializeComponent();
        }

        private void AddDetails_Load(object sender, EventArgs e)
        {
            ContainersHelper.GetInstance().GetContainers();
            BindingListsHelper.ReplaceRange(this.containersList, ContainersHelper.containers);
            this.containerComboBox.DataSource = this.containersList;
            this.containerComboBox.DisplayMember = "Name";
        }

        private void AddDetails_Shown(object sender, EventArgs e)
        {
            this.containerNameOrBarcode.Focus();
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

        private void detailName_TextChanged(object sender, EventArgs e)
        {
            this.SetIsButtonEnabled();
        }

        private void containerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetIsButtonEnabled();
        }

        private void SetIsButtonEnabled()
        {
            this.addDetailButton.Enabled = this.containerComboBox.SelectedItem != null && !String.IsNullOrEmpty(this.detailName.Text) && this.amountOfDetails.Value != null && this.amountOfDetails.Value > 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDetailButton_Click(object sender, EventArgs e)
        {
            var detailRow = new DetailRow();
            detailRow.Name = this.detailName.Text;
            detailRow.ContainerId = ((ContainerRow)this.containerComboBox.SelectedItem).ContainerId;
            var addedDetails = new List<DetailRow>();
            for (int i = 0; i < ((int)this.amountOfDetails.Value); i++)
            {
                addedDetails.Add(detailRow.CopyDetailRowWihtNewId());
            }
            DBHelper.GetInstance().AddDetails(addedDetails);
            MainWindow.RecreateDetailsList();
            this.containerNameOrBarcode.Clear();
            this.detailName.Clear();
            this.amountOfDetails.Value = 1;
            this.containerNameOrBarcode.Focus();
        }
    }
}
