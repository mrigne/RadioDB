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
    public partial class PickDetail : Form
    {
        DetailRow currentDetailRow;
        public PickDetail(DetailRow detailRow)
        {
            InitializeComponent();
            this.currentDetailRow = detailRow;
            this.detailName.Text = detailRow.Name;
            this.containerName.Text = detailRow.ContainerName ?? String.Empty;
            this.amountOfDetailsToEject.Value = 1;
            this.amountOfDetailsToEject.Maximum = detailRow.Count;
        }

        private void PickDetailButton_Click(object sender, EventArgs e)
        {
            DBHelper.GetInstance().DeleteTopNRows(this.currentDetailRow.Name, this.currentDetailRow.ContainerId, (int)this.amountOfDetailsToEject.Value);
            MainWindow.RecreateDetailsList();
            this.Dispose();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
