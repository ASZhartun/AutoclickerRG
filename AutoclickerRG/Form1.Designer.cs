namespace AutoclickerRG
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
            this.CPSValue = new System.Windows.Forms.TextBox();
            this.CPSSetButton = new System.Windows.Forms.Button();
            this.CPSForm = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CPSForm.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPSValue
            // 
            this.CPSValue.Location = new System.Drawing.Point(6, 19);
            this.CPSValue.MaxLength = 100;
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(46, 20);
            this.CPSValue.TabIndex = 0;
            this.CPSValue.Text = "1";
            // 
            // CPSSetButton
            // 
            this.CPSSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CPSSetButton.Location = new System.Drawing.Point(66, 19);
            this.CPSSetButton.Name = "CPSSetButton";
            this.CPSSetButton.Size = new System.Drawing.Size(46, 20);
            this.CPSSetButton.TabIndex = 1;
            this.CPSSetButton.Text = "Set";
            this.CPSSetButton.UseVisualStyleBackColor = true;
            this.CPSSetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CPSForm
            // 
            this.CPSForm.Controls.Add(this.CPSSetButton);
            this.CPSForm.Controls.Add(this.CPSValue);
            this.CPSForm.Location = new System.Drawing.Point(12, 12);
            this.CPSForm.Name = "CPSForm";
            this.CPSForm.Size = new System.Drawing.Size(115, 57);
            this.CPSForm.TabIndex = 2;
            this.CPSForm.TabStop = false;
            this.CPSForm.Text = "CPS";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 75);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Left-Up corner";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "set";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Location = new System.Drawing.Point(134, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 75);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Right-Down corner";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "set";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 20);
            this.textBox5.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(133, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 105);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Focus frame";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox1.Location = new System.Drawing.Point(34, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Running";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 124);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CPSForm);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Autoclicker menu";
            this.CPSForm.ResumeLayout(false);
            this.CPSForm.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CPSValue;
        private System.Windows.Forms.Button CPSSetButton;
        private System.Windows.Forms.GroupBox CPSForm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

