namespace GameLoop.Entity
{
    partial class ExitGame
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
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_resume
            // 
            this.btn_resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn_resume.Location = new System.Drawing.Point(12, 12);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(176, 53);
            this.btn_resume.TabIndex = 0;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn_settings.Location = new System.Drawing.Point(12, 71);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(176, 53);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "Sound";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn_quit.Location = new System.Drawing.Point(12, 130);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(176, 53);
            this.btn_quit.TabIndex = 2;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // ExitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameLoop.Properties.Resources.dank_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(197, 190);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_resume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitGame";
            this.Text = "ExitGame";
            this.Load += new System.EventHandler(this.ExitGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_quit;
    }
}