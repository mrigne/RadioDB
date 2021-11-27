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
    public partial class ManageContainers : Form
    {
        public static SortableBindingList<ContainerRow> containersBindingList = new SortableBindingList<ContainerRow>();
        public static ManageContainers instance;
        public static int? sortingColumnIndex = 0;
        public static ListSortDirection? sortingDirection = ListSortDirection.Ascending;
        public ManageContainers()
        {
            instance = this;
            InitializeComponent();
        }

        public static void ReCreateContainersList()
        {
            ContainersHelper.GetInstance().GetContainers();
            DetailsHelpers.GetInstance().GetDetails();

            BindingListsHelper.ReplaceRange(
                ManageContainers.containersBindingList,
                ContainersHelper.containers.Select(container =>
                {
                    container.DetailsCount = DetailsHelpers.details.Where(detail => detail.ContainerId == container.ContainerId).Count();
                    return container;
                }).ToList()
            );

            if (sortingColumnIndex != null)
            {
                instance.containersDataGridView.Sort(instance.containersDataGridView.Columns[(int)sortingColumnIndex], (ListSortDirection)sortingDirection);
            }
            
        }

        private void ManageContainers_Load(object sender, EventArgs e)
        {
            ManageContainers.containersBindingList = new SortableBindingList<ContainerRow>();
            this.containersDataGridView.AutoGenerateColumns = false;
            this.containersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ContainerName.DataPropertyName = "Name";
            this.ContainerBarcode.DataPropertyName = "Barcode";
            this.DetailsCount.DataPropertyName = "DetailsCount";
            this.containersDataGridView.AllowUserToResizeRows = false;
            this.containersDataGridView.RowHeadersVisible = false;
            this.containersDataGridView.DataSource = ManageContainers.containersBindingList;
            ManageContainers.ReCreateContainersList();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!Prompt.ShowDialog("Удалить контейнер", "Все детали в контейнере будут также удалены. \nУдалить контейнер?"))
            {
                return;
            }
            var selectedRows = this.containersDataGridView.SelectedRows;
            var selectedRowsCount = selectedRows.Count;
            var dbInstance = DBHelper.GetInstance();
            for (int i = 0; i < selectedRowsCount; i++)
            {
                var selectedRow = (ContainerRow)selectedRows[i].DataBoundItem;
                dbInstance.DeleteAllDetailsFromContainer(selectedRow.ContainerId);
                dbInstance.DeleteContainer(selectedRow.ContainerId);
            }
            ManageContainers.ReCreateContainersList();
            MainWindow.RecreateDetailsList();
        }

        private void ManageContainers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.containersDataGridView.DataSource = null;
            ManageContainers.containersBindingList = null;
        }

        private void addNewContainer_Click(object sender, EventArgs e)
        {
            var addContainerForm = new AddContainer();
            addContainerForm.ShowDialog();
        }

        private void containersDataGridView_Sorted(object sender, EventArgs e)
        {
            var sortingColumn = this.containersDataGridView.SortedColumn;
            if (sortingColumn != null)
            {
                ManageContainers.sortingColumnIndex = this.containersDataGridView.SortedColumn.Index;
                ManageContainers.sortingDirection = this.containersDataGridView.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            } else
            {
                ManageContainers.sortingColumnIndex = null;
                ManageContainers.sortingDirection = null;
            }
        }

        private void containersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var containerRow = (ContainerRow)this.containersDataGridView.Rows[e.RowIndex].DataBoundItem;
                var editContainerForm = new EditContainer(containerRow);
                editContainerForm.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var editContainerForm = new EditContainer((ContainerRow)this.containersDataGridView.CurrentRow.DataBoundItem);
            editContainerForm.ShowDialog();
        }

        private void closeButtonForKeyboardEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                var currentSelectedRow = this.containersDataGridView.CurrentRow;
                if (currentSelectedRow != null)
                {
                    var editContainerForm = new EditContainer((ContainerRow)currentSelectedRow.DataBoundItem);
                    editContainerForm.ShowDialog();
                }
            }
        }
    }
}
