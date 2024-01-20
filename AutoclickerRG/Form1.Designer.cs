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
            this.LeftUpX = new System.Windows.Forms.TextBox();
            this.LeftUpY = new System.Windows.Forms.TextBox();
            this.LeftUpCornerForm = new System.Windows.Forms.GroupBox();
            this.LeftUpSetButton = new System.Windows.Forms.Button();
            this.RightDownCornerForm = new System.Windows.Forms.GroupBox();
            this.RightDownSetButton = new System.Windows.Forms.Button();
            this.RightDownX = new System.Windows.Forms.TextBox();
            this.RightDownY = new System.Windows.Forms.TextBox();
            this.FocusFrame = new System.Windows.Forms.GroupBox();
            this.RunStateMark = new System.Windows.Forms.CheckBox();
            this.CPSForm.SuspendLayout();
            this.LeftUpCornerForm.SuspendLayout();
            this.RightDownCornerForm.SuspendLayout();
            this.FocusFrame.SuspendLayout();
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
            // LeftUpX
            // 
            this.LeftUpX.Location = new System.Drawing.Point(6, 19);
            this.LeftUpX.Name = "LeftUpX";
            this.LeftUpX.Size = new System.Drawing.Size(50, 20);
            this.LeftUpX.TabIndex = 3;
            // 
            // LeftUpY
            // 
            this.LeftUpY.Location = new System.Drawing.Point(6, 45);
            this.LeftUpY.Name = "LeftUpY";
            this.LeftUpY.Size = new System.Drawing.Size(50, 20);
            this.LeftUpY.TabIndex = 4;
            // 
            // LeftUpCornerForm
            // 
            this.LeftUpCornerForm.Controls.Add(this.LeftUpSetButton);
            this.LeftUpCornerForm.Controls.Add(this.LeftUpX);
            this.LeftUpCornerForm.Controls.Add(this.LeftUpY);
            this.LeftUpCornerForm.Location = new System.Drawing.Point(6, 19);
            this.LeftUpCornerForm.Name = "LeftUpCornerForm";
            this.LeftUpCornerForm.Size = new System.Drawing.Size(110, 75);
            this.LeftUpCornerForm.TabIndex = 5;
            this.LeftUpCornerForm.TabStop = false;
            this.LeftUpCornerForm.Text = "Left-Up corner";
            // 
            // LeftUpSetButton
            // 
            this.LeftUpSetButton.Location = new System.Drawing.Point(62, 19);
            this.LeftUpSetButton.Name = "LeftUpSetButton";
            this.LeftUpSetButton.Size = new System.Drawing.Size(43, 46);
            this.LeftUpSetButton.TabIndex = 5;
            this.LeftUpSetButton.Text = "set";
            this.LeftUpSetButton.UseVisualStyleBackColor = true;
            // 
            // RightDownCornerForm
            // 
            this.RightDownCornerForm.Controls.Add(this.RightDownSetButton);
            this.RightDownCornerForm.Controls.Add(this.RightDownX);
            this.RightDownCornerForm.Controls.Add(this.RightDownY);
            this.RightDownCornerForm.Location = new System.Drawing.Point(134, 19);
            this.RightDownCornerForm.Name = "RightDownCornerForm";
            this.RightDownCornerForm.Size = new System.Drawing.Size(110, 75);
            this.RightDownCornerForm.TabIndex = 6;
            this.RightDownCornerForm.TabStop = false;
            this.RightDownCornerForm.Text = "Right-Down corner";
            // 
            // RightDownSetButton
            // 
            this.RightDownSetButton.Location = new System.Drawing.Point(62, 19);
            this.RightDownSetButton.Name = "RightDownSetButton";
            this.RightDownSetButton.Size = new System.Drawing.Size(43, 46);
            this.RightDownSetButton.TabIndex = 5;
            this.RightDownSetButton.Text = "set";
            this.RightDownSetButton.UseVisualStyleBackColor = true;
            // 
            // RightDownX
            // 
            this.RightDownX.Location = new System.Drawing.Point(6, 19);
            this.RightDownX.Name = "RightDownX";
            this.RightDownX.Size = new System.Drawing.Size(50, 20);
            this.RightDownX.TabIndex = 3;
            // 
            // RightDownY
            // 
            this.RightDownY.Location = new System.Drawing.Point(6, 45);
            this.RightDownY.Name = "RightDownY";
            this.RightDownY.Size = new System.Drawing.Size(50, 20);
            this.RightDownY.TabIndex = 4;
            // 
            // FocusFrame
            // 
            this.FocusFrame.Controls.Add(this.LeftUpCornerForm);
            this.FocusFrame.Controls.Add(this.RightDownCornerForm);
            this.FocusFrame.Location = new System.Drawing.Point(133, 13);
            this.FocusFrame.Name = "FocusFrame";
            this.FocusFrame.Size = new System.Drawing.Size(250, 105);
            this.FocusFrame.TabIndex = 7;
            this.FocusFrame.TabStop = false;
            this.FocusFrame.Text = "Focus frame";
            // 
            // RunStateMark
            // 
            this.RunStateMark.AutoSize = true;
            this.RunStateMark.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RunStateMark.Location = new System.Drawing.Point(34, 90);
            this.RunStateMark.Name = "RunStateMark";
            this.RunStateMark.Size = new System.Drawing.Size(66, 17);
            this.RunStateMark.TabIndex = 8;
            this.RunStateMark.Text = "Running";
            this.RunStateMark.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 124);
            this.Controls.Add(this.RunStateMark);
            this.Controls.Add(this.FocusFrame);
            this.Controls.Add(this.CPSForm);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Autoclicker menu";
            this.CPSForm.ResumeLayout(false);
            this.CPSForm.PerformLayout();
            this.LeftUpCornerForm.ResumeLayout(false);
            this.LeftUpCornerForm.PerformLayout();
            this.RightDownCornerForm.ResumeLayout(false);
            this.RightDownCornerForm.PerformLayout();
            this.FocusFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CPSValue;
        private System.Windows.Forms.Button CPSSetButton;
        private System.Windows.Forms.GroupBox CPSForm;
        private System.Windows.Forms.TextBox LeftUpX;
        private System.Windows.Forms.TextBox LeftUpY;
        private System.Windows.Forms.GroupBox LeftUpCornerForm;
        private System.Windows.Forms.Button LeftUpSetButton;
        private System.Windows.Forms.GroupBox RightDownCornerForm;
        private System.Windows.Forms.Button RightDownSetButton;
        private System.Windows.Forms.TextBox RightDownX;
        private System.Windows.Forms.TextBox RightDownY;
        private System.Windows.Forms.GroupBox FocusFrame;
        private System.Windows.Forms.CheckBox RunStateMark;
    }
}

