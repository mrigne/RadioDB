
namespace TestRadioDB
{
    partial class AddContainer
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
            this.cancelAddContainerButton = new System.Windows.Forms.Button();
            this.addContainerButton = new System.Windows.Forms.Button();
            this.containerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.containerNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.barcodeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 193);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelAddContainerButton);
            this.panel2.Controls.Add(this.addContainerButton);
            this.panel2.Location = new System.Drawing.Point(4, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 30);
            this.panel2.TabIndex = 4;
            // 
            // cancelAddContainerButton
            // 
            this.cancelAddContainerButton.AutoSize = true;
            this.cancelAddContainerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelAddContainerButton.Location = new System.Drawing.Point(146, 0);
            this.cancelAddContainerButton.Name = "cancelAddContainerButton";
            this.cancelAddContainerButton.Size = new System.Drawing.Size(130, 30);
            this.cancelAddContainerButton.TabIndex = 1;
            this.cancelAddContainerButton.Text = "Отмена";
            this.cancelAddContainerButton.UseVisualStyleBackColor = true;
            this.cancelAddContainerButton.Click += new System.EventHandler(this.cancelAddContainerButton_Click);
            // 
            // addContainerButton
            // 
            this.addContainerButton.AutoSize = true;
            this.addContainerButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addContainerButton.Location = new System.Drawing.Point(0, 0);
            this.addContainerButton.Name = "addContainerButton";
            this.addContainerButton.Size = new System.Drawing.Size(130, 30);
            this.addContainerButton.TabIndex = 0;
            this.addContainerButton.Text = "Добавить контейнер";
            this.addContainerButton.UseVisualStyleBackColor = true;
            this.addContainerButton.Click += new System.EventHandler(this.addContainerButton_Click);
            // 
            // containerNameTextBox
            // 
            this.containerNameTextBox.Location = new System.Drawing.Point(4, 71);
            this.containerNameTextBox.Name = "containerNameTextBox";
            this.containerNameTextBox.Size = new System.Drawing.Size(276, 23);
            this.containerNameTextBox.TabIndex = 3;
            this.containerNameTextBox.TextChanged += new System.EventHandler(this.containerNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя контейнера";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(4, 22);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(276, 23);
            this.barcodeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Штрихкод (необязательно)";
            // 
            // AddContainer
            // 
            this.AcceptButton = this.addContainerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelAddContainerButton;
            this.ClientSize = new System.Drawing.Size(308, 218);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddContainer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить контейнер";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelAddContainerButton;
        private System.Windows.Forms.Button addContainerButton;
        private System.Windows.Forms.TextBox containerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label label1;
    }
}