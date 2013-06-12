namespace WindowsFormsApplication1
{
    partial class MathStuffForm
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
            this.operand1_label = new System.Windows.Forms.Label();
            this.operand1 = new System.Windows.Forms.MaskedTextBox();
            this.operand2 = new System.Windows.Forms.MaskedTextBox();
            this.operand2_label = new System.Windows.Forms.Label();
            this.mathify_button = new System.Windows.Forms.Button();
            this.add_label = new System.Windows.Forms.Label();
            this.mult_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // operand1_label
            // 
            this.operand1_label.AutoSize = true;
            this.operand1_label.Location = new System.Drawing.Point(55, 64);
            this.operand1_label.Name = "operand1_label";
            this.operand1_label.Size = new System.Drawing.Size(57, 13);
            this.operand1_label.TabIndex = 1;
            this.operand1_label.Text = "Operand 1";
            // 
            // operand1
            // 
            this.operand1.Location = new System.Drawing.Point(118, 61);
            this.operand1.Mask = "#####";
            this.operand1.Name = "operand1";
            this.operand1.PromptChar = ' ';
            this.operand1.Size = new System.Drawing.Size(39, 20);
            this.operand1.TabIndex = 2;
            // 
            // operand2
            // 
            this.operand2.Location = new System.Drawing.Point(118, 86);
            this.operand2.Mask = "#####";
            this.operand2.Name = "operand2";
            this.operand2.PromptChar = ' ';
            this.operand2.Size = new System.Drawing.Size(39, 20);
            this.operand2.TabIndex = 4;
            // 
            // operand2_label
            // 
            this.operand2_label.AutoSize = true;
            this.operand2_label.Location = new System.Drawing.Point(55, 89);
            this.operand2_label.Name = "operand2_label";
            this.operand2_label.Size = new System.Drawing.Size(57, 13);
            this.operand2_label.TabIndex = 3;
            this.operand2_label.Text = "Operand 2";
            // 
            // mathify_button
            // 
            this.mathify_button.Location = new System.Drawing.Point(82, 112);
            this.mathify_button.Name = "mathify_button";
            this.mathify_button.Size = new System.Drawing.Size(75, 23);
            this.mathify_button.TabIndex = 5;
            this.mathify_button.Text = "Mathify!";
            this.mathify_button.UseVisualStyleBackColor = true;
            this.mathify_button.Click += new System.EventHandler(this.mathify_button_Click);
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Location = new System.Drawing.Point(218, 68);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(0, 13);
            this.add_label.TabIndex = 6;
            // 
            // mult_label
            // 
            this.mult_label.AutoSize = true;
            this.mult_label.Location = new System.Drawing.Point(218, 89);
            this.mult_label.Name = "mult_label";
            this.mult_label.Size = new System.Drawing.Size(0, 13);
            this.mult_label.TabIndex = 7;
            // 
            // MathStuffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 406);
            this.Controls.Add(this.mult_label);
            this.Controls.Add(this.add_label);
            this.Controls.Add(this.mathify_button);
            this.Controls.Add(this.operand2);
            this.Controls.Add(this.operand2_label);
            this.Controls.Add(this.operand1);
            this.Controls.Add(this.operand1_label);
            this.Name = "MathStuffForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label operand1_label;
        private System.Windows.Forms.MaskedTextBox operand1;
        private System.Windows.Forms.MaskedTextBox operand2;
        private System.Windows.Forms.Label operand2_label;
        private System.Windows.Forms.Button mathify_button;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.Label mult_label;
    }
}

