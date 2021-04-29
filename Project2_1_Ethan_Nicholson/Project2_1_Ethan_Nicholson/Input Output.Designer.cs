namespace Project2_1_Ethan_Nicholson
{
    partial class Input_Output
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
            this.lstNums = new System.Windows.Forms.ListBox();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNums
            // 
            this.lstNums.FormattingEnabled = true;
            this.lstNums.Location = new System.Drawing.Point(72, 57);
            this.lstNums.Name = "lstNums";
            this.lstNums.Size = new System.Drawing.Size(185, 225);
            this.lstNums.TabIndex = 0;
            // 
            // btnGrades
            // 
            this.btnGrades.Location = new System.Drawing.Point(127, 306);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(75, 23);
            this.btnGrades.TabIndex = 1;
            this.btnGrades.Text = "&Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(127, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Input_Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.lstNums);
            this.Name = "Input_Output";
            this.Text = "Input_Output";
            this.Load += new System.EventHandler(this.Input_Output_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNums;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnClose;
    }
}