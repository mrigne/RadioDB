
namespace TestRadioDB
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchDetailTextBox = new System.Windows.Forms.TextBox();
            this.pickButtonForEnterKey = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addButtonToolBar = new System.Windows.Forms.ToolStripButton();
            this.pickButtonToolBar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.manageContainersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namageContainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detailName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailContainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailInContainerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pickDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.detailContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pickButtonForEnterKey);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 118);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.searchDetailTextBox);
            this.panel2.Location = new System.Drawing.Point(-9, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 62);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название детали";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(926, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchDetailTextBox
            // 
            this.searchDetailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchDetailTextBox.Location = new System.Drawing.Point(23, 32);
            this.searchDetailTextBox.Name = "searchDetailTextBox";
            this.searchDetailTextBox.Size = new System.Drawing.Size(897, 23);
            this.searchDetailTextBox.TabIndex = 1;
            this.searchDetailTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchDetailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchDetailTextBox_KeyDown);
            this.searchDetailTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchDetailTextBox_PreviewKeyDown);
            // 
            // pickButtonForEnterKey
            // 
            this.pickButtonForEnterKey.Location = new System.Drawing.Point(1027, 58);
            this.pickButtonForEnterKey.Name = "pickButtonForEnterKey";
            this.pickButtonForEnterKey.Size = new System.Drawing.Size(13, 24);
            this.pickButtonForEnterKey.TabIndex = 4;
            this.pickButtonForEnterKey.Text = "p";
            this.pickButtonForEnterKey.UseVisualStyleBackColor = true;
            this.pickButtonForEnterKey.Click += new System.EventHandler(this.pickToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButtonToolBar,
            this.pickButtonToolBar,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.manageContainersToolStripButton,
            this.toolStripSeparator2,
            this.exitToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(13, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1002, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addButtonToolBar
            // 
            this.addButtonToolBar.AutoToolTip = false;
            this.addButtonToolBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButtonToolBar.Image = global::TestRadioDB.Properties.Resources.plus_black_symbol_icon_icons_com_73453;
            this.addButtonToolBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButtonToolBar.Name = "addButtonToolBar";
            this.addButtonToolBar.Size = new System.Drawing.Size(23, 22);
            this.addButtonToolBar.Text = "toolStripButton1";
            this.addButtonToolBar.ToolTipText = "Добавить новую деталь (Ctrl + N)";
            this.addButtonToolBar.Click += new System.EventHandler(this.AddPartToolStripMenuItem_Click);
            // 
            // pickButtonToolBar
            // 
            this.pickButtonToolBar.AutoToolTip = false;
            this.pickButtonToolBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickButtonToolBar.Image = global::TestRadioDB.Properties.Resources.eject_icon_134496;
            this.pickButtonToolBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickButtonToolBar.Name = "pickButtonToolBar";
            this.pickButtonToolBar.Size = new System.Drawing.Size(23, 22);
            this.pickButtonToolBar.Text = "toolStripButton2";
            this.pickButtonToolBar.ToolTipText = "Извлечь деталь (Enter)";
            this.pickButtonToolBar.Click += new System.EventHandler(this.pickToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TestRadioDB.Properties.Resources.pencil_icon_icons_com_73464;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Изменить (F2)";
            this.toolStripButton1.Click += new System.EventHandler(this.editDetailToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // manageContainersToolStripButton
            // 
            this.manageContainersToolStripButton.AutoToolTip = false;
            this.manageContainersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manageContainersToolStripButton.Image = global::TestRadioDB.Properties.Resources.drawer_drawers_icon_149731;
            this.manageContainersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.manageContainersToolStripButton.Name = "manageContainersToolStripButton";
            this.manageContainersToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.manageContainersToolStripButton.Text = "toolStripButton3";
            this.manageContainersToolStripButton.ToolTipText = "Управление контейнерами (Ctrl + E)";
            this.manageContainersToolStripButton.Click += new System.EventHandler(this.ManageStoragesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // exitToolStripButton
            // 
            this.exitToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripButton.AutoToolTip = false;
            this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripButton.Image = global::TestRadioDB.Properties.Resources.exit_icon_icons_com_70975;
            this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripButton.Margin = new System.Windows.Forms.Padding(0, 1, 18, 2);
            this.exitToolStripButton.Name = "exitToolStripButton";
            this.exitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.exitToolStripButton.Text = "toolStripButton1";
            this.exitToolStripButton.ToolTipText = "Выход (Alt + F4)";
            this.exitToolStripButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.containersToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TestRadioDB.Properties.Resources.exit_icon_icons_com_70975;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.pickToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.detailsToolStripMenuItem.Text = "Детали";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::TestRadioDB.Properties.Resources.plus_black_symbol_icon_icons_com_73453;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddPartToolStripMenuItem_Click);
            // 
            // pickToolStripMenuItem
            // 
            this.pickToolStripMenuItem.Image = global::TestRadioDB.Properties.Resources.eject_icon_134496;
            this.pickToolStripMenuItem.Name = "pickToolStripMenuItem";
            this.pickToolStripMenuItem.ShortcutKeyDisplayString = "Enter";
            this.pickToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pickToolStripMenuItem.Text = "Извлечь";
            this.pickToolStripMenuItem.Click += new System.EventHandler(this.pickToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Image = global::TestRadioDB.Properties.Resources.pencil_icon_icons_com_73464;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.editDetailToolStripMenuItem_Click);
            // 
            // containersToolStripMenuItem
            // 
            this.containersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namageContainersToolStripMenuItem});
            this.containersToolStripMenuItem.Name = "containersToolStripMenuItem";
            this.containersToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.containersToolStripMenuItem.Text = "Контейнеры";
            // 
            // namageContainersToolStripMenuItem
            // 
            this.namageContainersToolStripMenuItem.Image = global::TestRadioDB.Properties.Resources.drawer_drawers_icon_149731;
            this.namageContainersToolStripMenuItem.Name = "namageContainersToolStripMenuItem";
            this.namageContainersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.namageContainersToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.namageContainersToolStripMenuItem.Text = "Управление контейнерами";
            this.namageContainersToolStripMenuItem.Click += new System.EventHandler(this.ManageStoragesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailName,
            this.detailContainerName,
            this.detailInContainerCount});
            this.dataGridView1.Location = new System.Drawing.Point(13, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(983, 593);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // detailName
            // 
            this.detailName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailName.DataPropertyName = "Name";
            this.detailName.HeaderText = "Имя";
            this.detailName.Name = "detailName";
            this.detailName.ReadOnly = true;
            // 
            // detailContainerName
            // 
            this.detailContainerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.detailContainerName.DataPropertyName = "ContainerName";
            this.detailContainerName.HeaderText = "Имя Контейнера";
            this.detailContainerName.Name = "detailContainerName";
            this.detailContainerName.ReadOnly = true;
            this.detailContainerName.Width = 114;
            // 
            // detailInContainerCount
            // 
            this.detailInContainerCount.DataPropertyName = "Count";
            this.detailInContainerCount.HeaderText = "Количество деталей в контейнере";
            this.detailInContainerCount.MinimumWidth = 100;
            this.detailInContainerCount.Name = "detailInContainerCount";
            this.detailInContainerCount.ReadOnly = true;
            // 
            // detailContextMenuStrip1
            // 
            this.detailContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickDetailToolStripMenuItem,
            this.editDetailToolStripMenuItem});
            this.detailContextMenuStrip1.Name = "detailContextMenuStrip1";
            this.detailContextMenuStrip1.Size = new System.Drawing.Size(174, 48);
            // 
            // pickDetailToolStripMenuItem
            // 
            this.pickDetailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pickDetailToolStripMenuItem.Image = global::TestRadioDB.Properties.Resources.eject_icon_134496;
            this.pickDetailToolStripMenuItem.Name = "pickDetailToolStripMenuItem";
            this.pickDetailToolStripMenuItem.ShortcutKeyDisplayString = "Enter";
            this.pickDetailToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pickDetailToolStripMenuItem.Text = "Извлечь";
            this.pickDetailToolStripMenuItem.Click += new System.EventHandler(this.pickToolStripMenuItem_Click);
            // 
            // editDetailToolStripMenuItem
            // 
            this.editDetailToolStripMenuItem.Image = global::TestRadioDB.Properties.Resources.pencil_icon_icons_com_73464;
            this.editDetailToolStripMenuItem.Name = "editDetailToolStripMenuItem";
            this.editDetailToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.editDetailToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editDetailToolStripMenuItem.Text = "Редактировать";
            this.editDetailToolStripMenuItem.Click += new System.EventHandler(this.editDetailToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.pickButtonForEnterKey;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог деталей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.detailContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchDetailTextBox;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addButtonToolBar;
        private System.Windows.Forms.ToolStripButton pickButtonToolBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton manageContainersToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exitToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem namageContainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDetailToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip detailContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailName;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailContainerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailInContainerCount;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button pickButtonForEnterKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}

