
namespace TestRadioDB
{
    partial class PickDetail
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
            this.amountOfDetailsToEject = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.containerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.detailName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PickDetailButton = new System.Windows.Forms.Button();
            this.CancelPickDetailButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfDetailsToEject)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.amountOfDetailsToEject);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.containerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.detailName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 205);
            this.panel1.TabIndex = 0;
            // 
            // amountOfDetailsToEject
            // 
            this.amountOfDetailsToEject.Location = new System.Drawing.Point(4, 121);
            this.amountOfDetailsToEject.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.amountOfDetailsToEject.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountOfDetailsToEject.Name = "amountOfDetailsToEject";
            this.amountOfDetailsToEject.Size = new System.Drawing.Size(269, 23);
            this.amountOfDetailsToEject.TabIndex = 6;
            this.amountOfDetailsToEject.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество извлекаемых деталей";
            // 
            // containerName
            // 
            this.containerName.Enabled = false;
            this.containerName.Location = new System.Drawing.Point(4, 72);
            this.containerName.Name = "containerName";
            this.containerName.ReadOnly = true;
            this.containerName.Size = new System.Drawing.Size(269, 23);
            this.containerName.TabIndex = 4;
            this.containerName.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя Контейнера";
            // 
            // detailName
            // 
            this.detailName.Enabled = false;
            this.detailName.Location = new System.Drawing.Point(4, 23);
            this.detailName.Name = "detailName";
            this.detailName.ReadOnly = true;
            this.detailName.Size = new System.Drawing.Size(269, 23);
            this.detailName.TabIndex = 2;
            this.detailName.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя детали";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PickDetailButton);
            this.panel2.Controls.Add(this.CancelPickDetailButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 30);
            this.panel2.TabIndex = 0;
            // 
            // PickDetailButton
            // 
            this.PickDetailButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PickDetailButton.Location = new System.Drawing.Point(0, 0);
            this.PickDetailButton.Name = "PickDetailButton";
            this.PickDetailButton.Size = new System.Drawing.Size(117, 30);
            this.PickDetailButton.TabIndex = 0;
            this.PickDetailButton.Text = "Извлечь деталь";
            this.PickDetailButton.UseVisualStyleBackColor = true;
            this.PickDetailButton.Click += new System.EventHandler(this.PickDetailButton_Click);
            // 
            // CancelPickDetailButton
            // 
            this.CancelPickDetailButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelPickDetailButton.Location = new System.Drawing.Point(201, 0);
            this.CancelPickDetailButton.Name = "CancelPickDetailButton";
            this.CancelPickDetailButton.Size = new System.Drawing.Size(75, 30);
            this.CancelPickDetailButton.TabIndex = 1;
            this.CancelPickDetailButton.Text = "Отмена";
            this.CancelPickDetailButton.UseVisualStyleBackColor = true;
            this.CancelPickDetailButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PickDetail
            // 
            this.AcceptButton = this.PickDetailButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPickDetailButton;
            this.ClientSize = new System.Drawing.Size(300, 229);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Извлечь деталь";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfDetailsToEject)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PickDetailButton;
        private System.Windows.Forms.Button CancelPickDetailButton;
        private System.Windows.Forms.NumericUpDown amountOfDetailsToEject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox containerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detailName;
        private System.Windows.Forms.Label label1;
    }
}