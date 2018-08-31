namespace Checkboxes_and_buttons
{
    partial class Form1
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
            this.nameBox = new System.Windows.Forms.ListBox();
            this.checkBoxBackPack = new System.Windows.Forms.CheckBox();
            this.radioButtonShort = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLong = new System.Windows.Forms.RadioButton();
            this.radioButtonBald = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBow = new System.Windows.Forms.CheckBox();
            this.checkBoxAxe = new System.Windows.Forms.CheckBox();
            this.checkBoxShoes = new System.Windows.Forms.CheckBox();
            this.checkBoxBoots = new System.Windows.Forms.CheckBox();
            this.checkBoxShield = new System.Windows.Forms.CheckBox();
            this.checkBoxSword = new System.Windows.Forms.CheckBox();
            this.checkBoxHelmet = new System.Windows.Forms.CheckBox();
            this.checkBoxArmor = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.hairLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nameBox.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameBox.FormattingEnabled = true;
            this.nameBox.ItemHeight = 26;
            this.nameBox.Items.AddRange(new object[] {
            "Bob June",
            "Greg Wills",
            "Stacy Grey",
            "Alexis Grant",
            "Terry Crews"});
            this.nameBox.Location = new System.Drawing.Point(22, 52);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 134);
            this.nameBox.TabIndex = 0;
            this.nameBox.SelectedIndexChanged += new System.EventHandler(this.nameBox_SelectedIndexChanged);
            // 
            // checkBoxBackPack
            // 
            this.checkBoxBackPack.AutoSize = true;
            this.checkBoxBackPack.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBackPack.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxBackPack.Location = new System.Drawing.Point(23, 50);
            this.checkBoxBackPack.Name = "checkBoxBackPack";
            this.checkBoxBackPack.Size = new System.Drawing.Size(97, 30);
            this.checkBoxBackPack.TabIndex = 1;
            this.checkBoxBackPack.Text = "Backpack ";
            this.checkBoxBackPack.UseVisualStyleBackColor = true;
            this.checkBoxBackPack.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // radioButtonShort
            // 
            this.radioButtonShort.AutoSize = true;
            this.radioButtonShort.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShort.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioButtonShort.Location = new System.Drawing.Point(29, 51);
            this.radioButtonShort.Name = "radioButtonShort";
            this.radioButtonShort.Size = new System.Drawing.Size(65, 30);
            this.radioButtonShort.TabIndex = 2;
            this.radioButtonShort.TabStop = true;
            this.radioButtonShort.Text = "Short";
            this.radioButtonShort.UseVisualStyleBackColor = true;
            this.radioButtonShort.CheckedChanged += new System.EventHandler(this.radioButtonShort_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Character Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLong);
            this.groupBox1.Controls.Add(this.radioButtonBald);
            this.groupBox1.Controls.Add(this.radioButtonShort);
            this.groupBox1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(22, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hair Style";
            // 
            // radioButtonLong
            // 
            this.radioButtonLong.AutoSize = true;
            this.radioButtonLong.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLong.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioButtonLong.Location = new System.Drawing.Point(29, 123);
            this.radioButtonLong.Name = "radioButtonLong";
            this.radioButtonLong.Size = new System.Drawing.Size(60, 30);
            this.radioButtonLong.TabIndex = 4;
            this.radioButtonLong.TabStop = true;
            this.radioButtonLong.Text = "Long";
            this.radioButtonLong.UseVisualStyleBackColor = true;
            this.radioButtonLong.CheckedChanged += new System.EventHandler(this.radioButtonLong_CheckedChanged);
            // 
            // radioButtonBald
            // 
            this.radioButtonBald.AutoSize = true;
            this.radioButtonBald.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBald.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioButtonBald.Location = new System.Drawing.Point(29, 87);
            this.radioButtonBald.Name = "radioButtonBald";
            this.radioButtonBald.Size = new System.Drawing.Size(63, 30);
            this.radioButtonBald.TabIndex = 3;
            this.radioButtonBald.TabStop = true;
            this.radioButtonBald.Text = "Bald";
            this.radioButtonBald.UseVisualStyleBackColor = true;
            this.radioButtonBald.CheckedChanged += new System.EventHandler(this.radioButtonBald_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxBow);
            this.groupBox2.Controls.Add(this.checkBoxAxe);
            this.groupBox2.Controls.Add(this.checkBoxShoes);
            this.groupBox2.Controls.Add(this.checkBoxBoots);
            this.groupBox2.Controls.Add(this.checkBoxShield);
            this.groupBox2.Controls.Add(this.checkBoxSword);
            this.groupBox2.Controls.Add(this.checkBoxHelmet);
            this.groupBox2.Controls.Add(this.checkBoxArmor);
            this.groupBox2.Controls.Add(this.checkBoxBackPack);
            this.groupBox2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(259, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 382);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // checkBoxBow
            // 
            this.checkBoxBow.AutoSize = true;
            this.checkBoxBow.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBow.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxBow.Location = new System.Drawing.Point(23, 338);
            this.checkBoxBow.Name = "checkBoxBow";
            this.checkBoxBow.Size = new System.Drawing.Size(58, 30);
            this.checkBoxBow.TabIndex = 9;
            this.checkBoxBow.Text = "Bow";
            this.checkBoxBow.UseVisualStyleBackColor = true;
            this.checkBoxBow.CheckedChanged += new System.EventHandler(this.checkBoxBow_CheckedChanged);
            // 
            // checkBoxAxe
            // 
            this.checkBoxAxe.AutoSize = true;
            this.checkBoxAxe.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAxe.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxAxe.Location = new System.Drawing.Point(23, 302);
            this.checkBoxAxe.Name = "checkBoxAxe";
            this.checkBoxAxe.Size = new System.Drawing.Size(53, 30);
            this.checkBoxAxe.TabIndex = 8;
            this.checkBoxAxe.Text = "Axe";
            this.checkBoxAxe.UseVisualStyleBackColor = true;
            this.checkBoxAxe.CheckedChanged += new System.EventHandler(this.checkBoxAxe_CheckedChanged);
            // 
            // checkBoxShoes
            // 
            this.checkBoxShoes.AutoSize = true;
            this.checkBoxShoes.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShoes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxShoes.Location = new System.Drawing.Point(23, 266);
            this.checkBoxShoes.Name = "checkBoxShoes";
            this.checkBoxShoes.Size = new System.Drawing.Size(64, 30);
            this.checkBoxShoes.TabIndex = 7;
            this.checkBoxShoes.Text = "Shoes";
            this.checkBoxShoes.UseVisualStyleBackColor = true;
            this.checkBoxShoes.CheckedChanged += new System.EventHandler(this.checkBoxShoes_CheckedChanged);
            // 
            // checkBoxBoots
            // 
            this.checkBoxBoots.AutoSize = true;
            this.checkBoxBoots.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBoots.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxBoots.Location = new System.Drawing.Point(23, 230);
            this.checkBoxBoots.Name = "checkBoxBoots";
            this.checkBoxBoots.Size = new System.Drawing.Size(67, 30);
            this.checkBoxBoots.TabIndex = 6;
            this.checkBoxBoots.Text = "Boots";
            this.checkBoxBoots.UseVisualStyleBackColor = true;
            this.checkBoxBoots.CheckedChanged += new System.EventHandler(this.checkBoxBoots_CheckedChanged);
            // 
            // checkBoxShield
            // 
            this.checkBoxShield.AutoSize = true;
            this.checkBoxShield.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShield.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxShield.Location = new System.Drawing.Point(23, 194);
            this.checkBoxShield.Name = "checkBoxShield";
            this.checkBoxShield.Size = new System.Drawing.Size(72, 30);
            this.checkBoxShield.TabIndex = 5;
            this.checkBoxShield.Text = "Shield";
            this.checkBoxShield.UseVisualStyleBackColor = true;
            this.checkBoxShield.CheckedChanged += new System.EventHandler(this.checkBoxShield_CheckedChanged);
            // 
            // checkBoxSword
            // 
            this.checkBoxSword.AutoSize = true;
            this.checkBoxSword.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxSword.Location = new System.Drawing.Point(23, 158);
            this.checkBoxSword.Name = "checkBoxSword";
            this.checkBoxSword.Size = new System.Drawing.Size(71, 30);
            this.checkBoxSword.TabIndex = 4;
            this.checkBoxSword.Text = "Sword";
            this.checkBoxSword.UseVisualStyleBackColor = true;
            this.checkBoxSword.CheckedChanged += new System.EventHandler(this.checkBoxSword_CheckedChanged);
            // 
            // checkBoxHelmet
            // 
            this.checkBoxHelmet.AutoSize = true;
            this.checkBoxHelmet.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHelmet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxHelmet.Location = new System.Drawing.Point(23, 122);
            this.checkBoxHelmet.Name = "checkBoxHelmet";
            this.checkBoxHelmet.Size = new System.Drawing.Size(77, 30);
            this.checkBoxHelmet.TabIndex = 3;
            this.checkBoxHelmet.Text = "Helmet";
            this.checkBoxHelmet.UseVisualStyleBackColor = true;
            this.checkBoxHelmet.CheckedChanged += new System.EventHandler(this.checkBoxHelmet_CheckedChanged);
            // 
            // checkBoxArmor
            // 
            this.checkBoxArmor.AutoSize = true;
            this.checkBoxArmor.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArmor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxArmor.Location = new System.Drawing.Point(23, 86);
            this.checkBoxArmor.Name = "checkBoxArmor";
            this.checkBoxArmor.Size = new System.Drawing.Size(74, 30);
            this.checkBoxArmor.TabIndex = 2;
            this.checkBoxArmor.Text = "Armor";
            this.checkBoxArmor.UseVisualStyleBackColor = true;
            this.checkBoxArmor.CheckedChanged += new System.EventHandler(this.checkBoxArmor_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(259, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Build Character";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemsLabel);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Location = new System.Drawing.Point(22, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 190);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Character";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // itemsLabel
            // 
            this.itemsLabel.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsLabel.Location = new System.Drawing.Point(23, 62);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(176, 110);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hairLabel
            // 
            this.hairLabel.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hairLabel.Location = new System.Drawing.Point(11, 24);
            this.hairLabel.Name = "hairLabel";
            this.hairLabel.Size = new System.Drawing.Size(176, 34);
            this.hairLabel.TabIndex = 1;
            this.hairLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox4.Location = new System.Drawing.Point(6, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 152);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Items";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nameLabel);
            this.groupBox5.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox5.Location = new System.Drawing.Point(222, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 69);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Name";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.hairLabel);
            this.groupBox6.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox6.Location = new System.Drawing.Point(222, 114);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(199, 67);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hair";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(11, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(176, 34);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(491, 694);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameBox;
        private System.Windows.Forms.CheckBox checkBoxBackPack;
        private System.Windows.Forms.RadioButton radioButtonShort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLong;
        private System.Windows.Forms.RadioButton radioButtonBald;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxBow;
        private System.Windows.Forms.CheckBox checkBoxAxe;
        private System.Windows.Forms.CheckBox checkBoxShoes;
        private System.Windows.Forms.CheckBox checkBoxBoots;
        private System.Windows.Forms.CheckBox checkBoxShield;
        private System.Windows.Forms.CheckBox checkBoxSword;
        private System.Windows.Forms.CheckBox checkBoxHelmet;
        private System.Windows.Forms.CheckBox checkBoxArmor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label hairLabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label nameLabel;
    }
}

