namespace Calculation_for_PI
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.termBox = new System.Windows.Forms.TextBox();
            this.answerLabelBox = new System.Windows.Forms.GroupBox();
            this.answerBox = new System.Windows.Forms.Label();
            this.answerLabelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(43, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter # of terms:";
            // 
            // termBox
            // 
            this.termBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.termBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termBox.ForeColor = System.Drawing.SystemColors.Window;
            this.termBox.Location = new System.Drawing.Point(155, 39);
            this.termBox.Name = "termBox";
            this.termBox.Size = new System.Drawing.Size(123, 26);
            this.termBox.TabIndex = 2;
            // 
            // answerLabelBox
            // 
            this.answerLabelBox.Controls.Add(this.answerBox);
            this.answerLabelBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabelBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.answerLabelBox.Location = new System.Drawing.Point(43, 175);
            this.answerLabelBox.Name = "answerLabelBox";
            this.answerLabelBox.Size = new System.Drawing.Size(235, 104);
            this.answerLabelBox.TabIndex = 3;
            this.answerLabelBox.TabStop = false;
            this.answerLabelBox.Text = "Answer";
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(6, 22);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(223, 70);
            this.answerBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(324, 315);
            this.Controls.Add(this.answerLabelBox);
            this.Controls.Add(this.termBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.answerLabelBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox termBox;
        private System.Windows.Forms.GroupBox answerLabelBox;
        private System.Windows.Forms.Label answerBox;
    }
}

