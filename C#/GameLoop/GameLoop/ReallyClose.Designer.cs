﻿namespace GameLoop
{
    partial class ReallyClose
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
            this.No = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // No
            // 
            this.No.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.No.Location = new System.Drawing.Point(343, 235);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(147, 50);
            this.No.TabIndex = 0;
            this.No.Text = "Nah m8";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Yes
            // 
            this.Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Yes.Location = new System.Drawing.Point(19, 235);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(180, 50);
            this.Yes.TabIndex = 1;
            this.Yes.Text = "Yeah m90";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you really want to quit, brah?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReallyClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.No);
            this.Name = "ReallyClose";
            this.Text = "ReallyClose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Label label1;
    }
}