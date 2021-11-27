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
    public partial class AddContainer : Form
    {
        public AddContainer()
        {
            InitializeComponent();
        }

        private void containerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.addContainerButton.Enabled = !String.IsNullOrEmpty(this.containerNameTextBox.Text);
        }

        private void cancelAddContainerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addContainerButton_Click(object sender, EventArgs e)
        {
            var newContainer = new ContainerRow();
            newContainer.Name = this.containerNameTextBox.Text;
            if (!String.IsNullOrEmpty(this.barcodeTextBox.Text))
            {
                newContainer.Barcode = this.barcodeTextBox.Text;
            }
            DBHelper.GetInstance().AddContainer(newContainer);
            ManageContainers.ReCreateContainersList();
            this.Close();
        }
    }
}
