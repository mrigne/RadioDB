
namespace TestRadioDB
{
    partial class AddDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.amountOfDetails = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addDetailButton = new System.Windows.Forms.Button();
            this.detailName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.containerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.containerNameOrBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.amountOfDetails);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.detailName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.containerComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.containerNameOrBarcode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 251);
            this.panel1.TabIndex = 0;
            // 
            // amountOfDetails
            // 
            this.amountOfDetails.Location = new System.Drawing.Point(4, 170);
            this.amountOfDetails.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.amountOfDetails.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountOfDetails.Name = "amountOfDetails";
            this.amountOfDetails.Size = new System.Drawing.Size(268, 23);
            this.amountOfDetails.TabIndex = 7;
            this.amountOfDetails.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество деталей";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.addDetailButton);
            this.panel2.Location = new System.Drawing.Point(4, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 30);
            this.panel2.TabIndex = 9;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelButton.Location = new System.Drawing.Point(193, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 30);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addDetailButton
            // 
            this.addDetailButton.AutoSize = true;
            this.addDetailButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addDetailButton.Location = new System.Drawing.Point(0, 0);
            this.addDetailButton.Name = "addDetailButton";
            this.addDetailButton.Size = new System.Drawing.Size(108, 30);
            this.addDetailButton.TabIndex = 0;
            this.addDetailButton.Text = "Добавить деталь";
            this.addDetailButton.UseVisualStyleBackColor = true;
            this.addDetailButton.Click += new System.EventHandler(this.addDetailButton_Click);
            // 
            // detailName
            // 
            this.detailName.Location = new System.Drawing.Point(4, 121);
            this.detailName.Name = "detailName";
            this.detailName.Size = new System.Drawing.Size(268, 23);
            this.detailName.TabIndex = 5;
            this.detailName.TextChanged += new System.EventHandler(this.detailName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя детали";
            // 
            // containerComboBox
            // 
            this.containerComboBox.FormattingEnabled = true;
            this.containerComboBox.Location = new System.Drawing.Point(4, 72);
            this.containerComboBox.Name = "containerComboBox";
            this.containerComboBox.Size = new System.Drawing.Size(268, 23);
            this.containerComboBox.TabIndex = 3;
            this.containerComboBox.TabStop = false;
            this.containerComboBox.SelectedIndexChanged += new System.EventHandler(this.containerComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Контейнер";
            // 
            // containerNameOrBarcode
            // 
            this.containerNameOrBarcode.Location = new System.Drawing.Point(4, 23);
            this.containerNameOrBarcode.Name = "containerNameOrBarcode";
            this.containerNameOrBarcode.Size = new System.Drawing.Size(268, 23);
            this.containerNameOrBarcode.TabIndex = 1;
            this.containerNameOrBarcode.TextChanged += new System.EventHandler(this.containerNameOrBarcode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Штрихкод или имя контейнера";
            // 
            // AddDetails
            // 
            this.AcceptButton = this.addDetailButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(300, 276);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить Деталь";
            this.Load += new System.EventHandler(this.AddDetails_Shown);
            this.Shown += new System.EventHandler(this.AddDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox containerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox containerNameOrBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox detailName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown amountOfDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addDetailButton;
    }
}