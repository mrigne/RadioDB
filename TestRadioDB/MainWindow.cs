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
    public partial class MainWindow : Form
    {
        public static SortableBindingList<DetailRow> detailsList = new SortableBindingList<DetailRow>();
        private static MainWindow instance;
        public static int? sortingColumnIndex = 0;
        public static ListSortDirection? sortingDirection = ListSortDirection.Ascending;
        public MainWindow()
        {
            MainWindow.instance = this;
            InitializeComponent();
        }

        public static void RecreateDetailsList() {
            DetailsHelpers.GetInstance().GetDetails();
            List<DetailRow> modifiedDetailsList = new List<DetailRow>();
            DetailsHelpers.details.ForEach(detailRow =>
            {
                var existedElement = modifiedDetailsList.Find(modifiedDetail => modifiedDetail.Name == detailRow.Name && modifiedDetail.ContainerId == detailRow.ContainerId);
                if (existedElement == null)
                {
                    modifiedDetailsList.Add(detailRow.Clone());
                }
                else
                {
                    existedElement.Count += 1;
                }
            });

            var filteredList = new List<DetailRow>();
            if (!String.IsNullOrEmpty(instance.searchDetailTextBox.Text))
            {
                filteredList.AddRange(modifiedDetailsList.Where(detailItem => detailItem.Name.ToUpper().Contains(instance.searchDetailTextBox.Text.ToUpper())));
                filteredList.AddRange(modifiedDetailsList.Where(detailItem => {
                    if (!String.IsNullOrEmpty(detailItem.ContainerName))
                    {
                        return detailItem.ContainerName.ToUpper().Contains(instance.searchDetailTextBox.Text.ToUpper());
                    }
                    return false;
                }));
                filteredList.AddRange(modifiedDetailsList.Where(detailItem => detailItem.ContainerBarcode == instance.searchDetailTextBox.Text));
            } else
            {
                filteredList.AddRange(modifiedDetailsList);
            }
            
            BindingListsHelper.ReplaceRange(detailsList, filteredList.Select(item => item).Distinct().ToList());

            if (sortingColumnIndex != null)
            {
                instance.dataGridView1.Sort(instance.dataGridView1.Columns[(int)sortingColumnIndex], (ListSortDirection)sortingDirection);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            detailsList = new SortableBindingList<DetailRow>();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.detailName.DataPropertyName = "Name";
            this.detailContainerName.DataPropertyName = "ContainerName";
            this.detailInContainerCount.DataPropertyName = "Count";
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.DataSource = detailsList;
            RecreateDetailsList();
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = (DetailRow)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var pickDetailForm = new PickDetail(row);
                pickDetailForm.ShowDialog();
            }
        }

        private void AddPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addDetailsForm = new AddDetails();
            addDetailsForm.ShowDialog();
        }

        private void ManageStoragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageContainersForm = new ManageContainers();
            manageContainersForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DetailsHelpers.GetInstance().GetDetails();
            List<DetailRow> modifiedDetailsList = new List<DetailRow>();
            DetailsHelpers.details.ForEach(detailRow =>
            {
                var existedElement = modifiedDetailsList.Find(modifiedDetail => modifiedDetail.Name == detailRow.Name && modifiedDetail.ContainerId == detailRow.ContainerId);
                if (existedElement == null)
                {
                    modifiedDetailsList.Add(detailRow.Clone());
                }
                else
                {
                    existedElement.Count += 1;
                }
            });
            var filteredList = new List<DetailRow>();
            filteredList.AddRange(modifiedDetailsList.Where(detailItem => detailItem.Name.ToUpper().Contains(this.searchDetailTextBox.Text.ToUpper())));
            filteredList.AddRange(modifiedDetailsList.Where(detailItem => {
                if (!String.IsNullOrEmpty(detailItem.ContainerName))
                {
                    return detailItem.ContainerName.ToUpper().Contains(this.searchDetailTextBox.Text.ToUpper());
                }
                return false;
            }));
            filteredList.AddRange(modifiedDetailsList.Where(detailItem => detailItem.ContainerBarcode == searchDetailTextBox.Text));
            BindingListsHelper.ReplaceRange(detailsList, filteredList.Select(item => item).Distinct().ToList());

            if (sortingColumnIndex != null)
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns[(int)sortingColumnIndex], (ListSortDirection)sortingDirection);
            }
        }

        private void searchDetailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.searchDetailTextBox.Focus();
                this.searchDetailTextBox.SelectAll();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                var currentSelectedRow = this.dataGridView1.CurrentRow;
                if (currentSelectedRow != null)
                {
                    var pickDetailForm = new PickDetail((DetailRow)currentSelectedRow.DataBoundItem);
                    pickDetailForm.ShowDialog();
                }
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void searchDetailTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentSelectedRow = this.dataGridView1.CurrentRow;
            if (currentSelectedRow != null)
            {
                var pickDetailForm = new PickDetail((DetailRow)currentSelectedRow.DataBoundItem);
                pickDetailForm.ShowDialog();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var canPickDetail = this.dataGridView1.SelectedRows.Count > 0;
            this.pickButtonToolBar.Enabled = canPickDetail;
            this.pickToolStripMenuItem.Enabled = canPickDetail;
            this.изменитьToolStripMenuItem.Enabled = canPickDetail;
            this.toolStripButton1.Enabled = canPickDetail;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
                this.detailContextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void editDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentSelectedRow = this.dataGridView1.CurrentRow;
            if (currentSelectedRow != null)
            {
                var editDetailForm = new EditDetail((DetailRow)currentSelectedRow.DataBoundItem);
                editDetailForm.ShowDialog();
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            var sortingColumn = this.dataGridView1.SortedColumn;
            if (sortingColumn != null)
            {
                MainWindow.sortingColumnIndex = this.dataGridView1.SortedColumn.Index;
                MainWindow.sortingDirection = this.dataGridView1.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            }
            else
            {
                MainWindow.sortingColumnIndex = null;
                MainWindow.sortingDirection = null;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                var currentSelectedRow = this.dataGridView1.CurrentRow;
                if (currentSelectedRow != null)
                {
                    var pickDetailForm = new PickDetail((DetailRow)currentSelectedRow.DataBoundItem);
                    pickDetailForm.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.searchDetailTextBox.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
