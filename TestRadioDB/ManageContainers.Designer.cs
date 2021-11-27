
namespace TestRadioDB
{
    partial class ManageContainers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageContainers));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addNewContainer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.containersDataGridView = new System.Windows.Forms.DataGridView();
            this.ContainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContainerBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButtonForKeyboardEscape = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewContainer,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(13, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 34);
            this.toolStrip1.TabIndex = 0;
            // 
            // addNewContainer
            // 
            this.addNewContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewContainer.Image = ((System.Drawing.Image)(resources.GetObject("addNewContainer.Image")));
            this.addNewContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewContainer.Name = "addNewContainer";
            this.addNewContainer.Size = new System.Drawing.Size(23, 31);
            this.addNewContainer.Text = "toolStripButton1";
            this.addNewContainer.ToolTipText = "Добавить";
            this.addNewContainer.Click += new System.EventHandler(this.addNewContainer_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 31);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TestRadioDB.Properties.Resources.pencil_icon_icons_com_73464;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 31);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Изменить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.containersDataGridView);
            this.panel1.Location = new System.Drawing.Point(13, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 439);
            this.panel1.TabIndex = 1;
            // 
            // containersDataGridView
            // 
            this.containersDataGridView.AllowUserToAddRows = false;
            this.containersDataGridView.AllowUserToDeleteRows = false;
            this.containersDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.containersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.containersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContainerName,
            this.ContainerBarcode,
            this.DetailsCount});
            this.containersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.containersDataGridView.Name = "containersDataGridView";
            this.containersDataGridView.ReadOnly = true;
            this.containersDataGridView.RowTemplate.Height = 25;
            this.containersDataGridView.Size = new System.Drawing.Size(558, 439);
            this.containersDataGridView.TabIndex = 0;
            this.containersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.containersDataGridView_CellDoubleClick);
            this.containersDataGridView.Sorted += new System.EventHandler(this.containersDataGridView_Sorted);
            this.containersDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // ContainerName
            // 
            this.ContainerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContainerName.HeaderText = "Имя";
            this.ContainerName.Name = "ContainerName";
            this.ContainerName.ReadOnly = true;
            // 
            // ContainerBarcode
            // 
            this.ContainerBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ContainerBarcode.HeaderText = "Штрихкод";
            this.ContainerBarcode.MinimumWidth = 200;
            this.ContainerBarcode.Name = "ContainerBarcode";
            this.ContainerBarcode.ReadOnly = true;
            this.ContainerBarcode.Width = 200;
            // 
            // DetailsCount
            // 
            this.DetailsCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DetailsCount.HeaderText = "Количество деталей";
            this.DetailsCount.MinimumWidth = 100;
            this.DetailsCount.Name = "DetailsCount";
            this.DetailsCount.ReadOnly = true;
            this.DetailsCount.Width = 131;
            // 
            // closeButtonForKeyboardEscape
            // 
            this.closeButtonForKeyboardEscape.Location = new System.Drawing.Point(607, 9);
            this.closeButtonForKeyboardEscape.Name = "closeButtonForKeyboardEscape";
            this.closeButtonForKeyboardEscape.Size = new System.Drawing.Size(19, 15);
            this.closeButtonForKeyboardEscape.TabIndex = 2;
            this.closeButtonForKeyboardEscape.Text = "button1";
            this.closeButtonForKeyboardEscape.UseVisualStyleBackColor = true;
            this.closeButtonForKeyboardEscape.Click += new System.EventHandler(this.closeButtonForKeyboardEscape_Click);
            // 
            // ManageContainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButtonForKeyboardEscape;
            this.ClientSize = new System.Drawing.Size(583, 497);
            this.Controls.Add(this.closeButtonForKeyboardEscape);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageContainers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление контейнерами";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageContainers_FormClosed);
            this.Load += new System.EventHandler(this.ManageContainers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addNewContainer;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView containersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContainerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContainerBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailsCount;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button closeButtonForKeyboardEscape;
    }
}