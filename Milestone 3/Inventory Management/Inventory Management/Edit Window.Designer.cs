namespace Inventory_Management
{
    partial class Edit_Window
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
            this.editCancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBoxEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modelNumTextBoxEdit = new System.Windows.Forms.TextBox();
            this.groupTextBoxEdit = new System.Windows.Forms.TextBox();
            this.quantityTextBoxEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemTextBoxEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editCancelButton
            // 
            this.editCancelButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCancelButton.Location = new System.Drawing.Point(7, 278);
            this.editCancelButton.Name = "editCancelButton";
            this.editCancelButton.Size = new System.Drawing.Size(116, 35);
            this.editCancelButton.TabIndex = 8;
            this.editCancelButton.Text = "Cancel";
            this.editCancelButton.UseVisualStyleBackColor = true;
            this.editCancelButton.Click += new System.EventHandler(this.EditCancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.priceTextBoxEdit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.modelNumTextBoxEdit);
            this.groupBox1.Controls.Add(this.groupTextBoxEdit);
            this.groupBox1.Controls.Add(this.quantityTextBoxEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.itemTextBoxEdit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(7, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 246);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceTextBoxEdit
            // 
            this.priceTextBoxEdit.Location = new System.Drawing.Point(94, 186);
            this.priceTextBoxEdit.Name = "priceTextBoxEdit";
            this.priceTextBoxEdit.Size = new System.Drawing.Size(122, 30);
            this.priceTextBoxEdit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model #:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // modelNumTextBoxEdit
            // 
            this.modelNumTextBoxEdit.Location = new System.Drawing.Point(94, 150);
            this.modelNumTextBoxEdit.Name = "modelNumTextBoxEdit";
            this.modelNumTextBoxEdit.Size = new System.Drawing.Size(122, 30);
            this.modelNumTextBoxEdit.TabIndex = 4;
            // 
            // groupTextBoxEdit
            // 
            this.groupTextBoxEdit.Location = new System.Drawing.Point(94, 114);
            this.groupTextBoxEdit.Name = "groupTextBoxEdit";
            this.groupTextBoxEdit.Size = new System.Drawing.Size(122, 30);
            this.groupTextBoxEdit.TabIndex = 3;
            // 
            // quantityTextBoxEdit
            // 
            this.quantityTextBoxEdit.Location = new System.Drawing.Point(94, 42);
            this.quantityTextBoxEdit.Name = "quantityTextBoxEdit";
            this.quantityTextBoxEdit.Size = new System.Drawing.Size(122, 30);
            this.quantityTextBoxEdit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // itemTextBoxEdit
            // 
            this.itemTextBoxEdit.Location = new System.Drawing.Point(94, 78);
            this.itemTextBoxEdit.Name = "itemTextBoxEdit";
            this.itemTextBoxEdit.Size = new System.Drawing.Size(122, 30);
            this.itemTextBoxEdit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(141, 278);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 35);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Edit_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(264, 330);
            this.Controls.Add(this.editCancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Name = "Edit_Window";
            this.Text = "Edit_Window";
            this.Load += new System.EventHandler(this.Edit_Window_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editCancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox priceTextBoxEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox modelNumTextBoxEdit;
        public System.Windows.Forms.TextBox groupTextBoxEdit;
        public System.Windows.Forms.TextBox quantityTextBoxEdit;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox itemTextBoxEdit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button saveButton;
    }
}