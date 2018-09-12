namespace Dice_Roll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rollDieButton = new System.Windows.Forms.Button();
            this.rightDie = new System.Windows.Forms.Label();
            this.leftDie = new System.Windows.Forms.Label();
            this.numSides = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollDieButton
            // 
            this.rollDieButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rollDieButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rollDieButton.BackgroundImage")));
            this.rollDieButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.rollDieButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rollDieButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollDieButton.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDieButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rollDieButton.Location = new System.Drawing.Point(211, 22);
            this.rollDieButton.Name = "rollDieButton";
            this.rollDieButton.Size = new System.Drawing.Size(225, 70);
            this.rollDieButton.TabIndex = 0;
            this.rollDieButton.Text = "ROLL DICE";
            this.rollDieButton.UseVisualStyleBackColor = false;
            this.rollDieButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightDie
            // 
            this.rightDie.BackColor = System.Drawing.SystemColors.Window;
            this.rightDie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightDie.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightDie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightDie.Image = ((System.Drawing.Image)(resources.GetObject("rightDie.Image")));
            this.rightDie.Location = new System.Drawing.Point(253, 119);
            this.rightDie.Name = "rightDie";
            this.rightDie.Size = new System.Drawing.Size(100, 91);
            this.rightDie.TabIndex = 2;
            this.rightDie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightDie.Click += new System.EventHandler(this.label2_Click);
            // 
            // leftDie
            // 
            this.leftDie.BackColor = System.Drawing.SystemColors.Window;
            this.leftDie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftDie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftDie.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftDie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leftDie.Image = ((System.Drawing.Image)(resources.GetObject("leftDie.Image")));
            this.leftDie.Location = new System.Drawing.Point(116, 119);
            this.leftDie.Name = "leftDie";
            this.leftDie.Size = new System.Drawing.Size(100, 91);
            this.leftDie.TabIndex = 3;
            this.leftDie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSides
            // 
            this.numSides.BackColor = System.Drawing.SystemColors.MenuBar;
            this.numSides.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSides.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numSides.Location = new System.Drawing.Point(35, 49);
            this.numSides.Name = "numSides";
            this.numSides.Size = new System.Drawing.Size(151, 32);
            this.numSides.TabIndex = 4;
            this.numSides.Text = "(min 4-max 20)";
            this.numSides.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "How many sides per die?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(469, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSides);
            this.Controls.Add(this.leftDie);
            this.Controls.Add(this.rightDie);
            this.Controls.Add(this.rollDieButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollDieButton;
        private System.Windows.Forms.Label rightDie;
        private System.Windows.Forms.Label leftDie;
        private System.Windows.Forms.TextBox numSides;
        private System.Windows.Forms.Label label1;
    }
}

