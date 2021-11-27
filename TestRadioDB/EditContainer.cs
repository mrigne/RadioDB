using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRadioDB.Models;

namespace TestRadioDB
{
    public partial class EditContainer : Form
    {
        private ContainerRow currentContainerRow;
        public EditContainer(ContainerRow containerRow)
        {
            this.currentContainerRow = containerRow;
            InitializeComponent();
        }

        private void containerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.saveContainerButton.Enabled = !String.IsNullOrEmpty(this.containerNameTextBox.Text);
        }

        private void cancelSaveContainerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveContainerButton_Click(object sender, EventArgs e)
        {
            this.currentContainerRow.Name = this.containerNameTextBox.Text;
            if (!String.IsNullOrEmpty(this.barcodeTextBox.Text))
            {
                this.currentContainerRow.Barcode = this.barcodeTextBox.Text;
            }
            DBHelper.GetInstance().UpdateContainer(this.currentContainerRow);
            ManageContainers.ReCreateContainersList();
            MainWindow.RecreateDetailsList();
            this.Close();
        }

        private void EditContainer_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.currentContainerRow.Barcode))
            {
                this.barcodeTextBox.Text = this.currentContainerRow.Barcode;
            }
            this.containerNameTextBox.Text = this.currentContainerRow.Name;
        }
    }
}
