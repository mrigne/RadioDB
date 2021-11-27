
namespace TestRadioDB
{
    partial class EditDetail
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveDetailButton = new System.Windows.Forms.Button();
            this.amountOfDetails = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.detailName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.containerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.containerNameOrBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 251);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.saveDetailButton);
            this.panel2.Location = new System.Drawing.Point(3, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 30);
            this.panel2.TabIndex = 10;
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
            // saveDetailButton
            // 
            this.saveDetailButton.AutoSize = true;
            this.saveDetailButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveDetailButton.Location = new System.Drawing.Point(0, 0);
            this.saveDetailButton.Name = "saveDetailButton";
            this.saveDetailButton.Size = new System.Drawing.Size(108, 30);
            this.saveDetailButton.TabIndex = 0;
            this.saveDetailButton.Text = "Сохранить";
            this.saveDetailButton.UseVisualStyleBackColor = true;
            this.saveDetailButton.Click += new System.EventHandler(this.saveDetailButton_Click);
            // 
            // amountOfDetails
            // 
            this.amountOfDetails.Location = new System.Drawing.Point(16, 182);
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
            this.amountOfDetails.TabIndex = 14;
            this.amountOfDetails.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountOfDetails.ValueChanged += new System.EventHandler(this.amountOfDetails_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Количество деталей";
            // 
            // detailName
            // 
            this.detailName.Location = new System.Drawing.Point(16, 133);
            this.detailName.Name = "detailName";
            this.detailName.Size = new System.Drawing.Size(268, 23);
            this.detailName.TabIndex = 13;
            this.detailName.TextChanged += new System.EventHandler(this.detailName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Имя детали";
            // 
            // containerComboBox
            // 
            this.containerComboBox.FormattingEnabled = true;
            this.containerComboBox.Location = new System.Drawing.Point(16, 84);
            this.containerComboBox.Name = "containerComboBox";
            this.containerComboBox.Size = new System.Drawing.Size(268, 23);
            this.containerComboBox.TabIndex = 11;
            this.containerComboBox.TabStop = false;
            this.containerComboBox.SelectedIndexChanged += new System.EventHandler(this.containerComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Контейнер";
            // 
            // containerNameOrBarcode
            // 
            this.containerNameOrBarcode.Location = new System.Drawing.Point(16, 35);
            this.containerNameOrBarcode.Name = "containerNameOrBarcode";
            this.containerNameOrBarcode.Size = new System.Drawing.Size(268, 23);
            this.containerNameOrBarcode.TabIndex = 9;
            this.containerNameOrBarcode.TextChanged += new System.EventHandler(this.containerNameOrBarcode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Штрихкод или имя контейнера";
            // 
            // EditDetail
            // 
            this.AcceptButton = this.saveDetailButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(300, 276);
            this.Controls.Add(this.amountOfDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detailName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.containerComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.containerNameOrBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить деталь";
            this.Load += new System.EventHandler(this.EditDetail_Load);
            this.Shown += new System.EventHandler(this.EditDetail_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown amountOfDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox containerNameOrBarcode;
        private System.Windows.Forms.TextBox detailName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox containerComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveDetailButton;
    }
}