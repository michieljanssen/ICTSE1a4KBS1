namespace Menutest
{
    partial class Main
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
            this.SelectLevel = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.QuitGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectLevel
            // 
            this.SelectLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectLevel.Location = new System.Drawing.Point(504, 56);
            this.SelectLevel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SelectLevel.Name = "SelectLevel";
            this.SelectLevel.Size = new System.Drawing.Size(238, 65);
            this.SelectLevel.TabIndex = 0;
            this.SelectLevel.Text = "Select Level";
            this.SelectLevel.UseVisualStyleBackColor = true;
            this.SelectLevel.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingsButton.Location = new System.Drawing.Point(504, 264);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(238, 65);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // QuitGameButton
            // 
            this.QuitGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuitGameButton.Location = new System.Drawing.Point(504, 462);
            this.QuitGameButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.QuitGameButton.Name = "QuitGameButton";
            this.QuitGameButton.Size = new System.Drawing.Size(238, 65);
            this.QuitGameButton.TabIndex = 2;
            this.QuitGameButton.Text = "Quit Game";
            this.QuitGameButton.UseVisualStyleBackColor = true;
            this.QuitGameButton.Click += new System.EventHandler(this.QuitGameButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.QuitGameButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SelectLevel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectLevel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button QuitGameButton;
    }
}

