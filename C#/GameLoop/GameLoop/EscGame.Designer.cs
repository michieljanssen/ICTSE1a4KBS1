namespace GameLoop
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
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.trb_Effects = new System.Windows.Forms.TrackBar();
            this.lbl_effectsVolume = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Effects)).BeginInit();
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
            // SettingsPanel
            // 
            this.SettingsPanel.BackgroundImage = global::GameLoop.Properties.Resources.dank_background;
            this.SettingsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsPanel.Controls.Add(this.trb_Effects);
            this.SettingsPanel.Controls.Add(this.lbl_effectsVolume);
            this.SettingsPanel.Controls.Add(this.btn_back);
            this.SettingsPanel.Location = new System.Drawing.Point(-1, -2);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(201, 196);
            this.SettingsPanel.TabIndex = 3;
            this.SettingsPanel.Visible = false;
            // 
            // trb_Effects
            // 
            this.trb_Effects.LargeChange = 10;
            this.trb_Effects.Location = new System.Drawing.Point(19, 102);
            this.trb_Effects.Maximum = 100;
            this.trb_Effects.Name = "trb_Effects";
            this.trb_Effects.Size = new System.Drawing.Size(167, 45);
            this.trb_Effects.SmallChange = 5;
            this.trb_Effects.TabIndex = 3;
            this.trb_Effects.TickFrequency = 5;
            this.trb_Effects.Scroll += new System.EventHandler(this.trb_Effects_Scroll);
            // 
            // lbl_effectsVolume
            // 
            this.lbl_effectsVolume.AutoSize = true;
            this.lbl_effectsVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_effectsVolume.Location = new System.Drawing.Point(20, 73);
            this.lbl_effectsVolume.Name = "lbl_effectsVolume";
            this.lbl_effectsVolume.Size = new System.Drawing.Size(166, 26);
            this.lbl_effectsVolume.TabIndex = 1;
            this.lbl_effectsVolume.Text = "Effects Volume:";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_back.Location = new System.Drawing.Point(65, 27);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ExitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameLoop.Properties.Resources.dank_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(197, 190);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_resume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitGame";
            this.Text = "ExitGame";
            this.Load += new System.EventHandler(this.ExitGame_Load);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Effects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_effectsVolume;
        private System.Windows.Forms.TrackBar trb_Effects;
    }
}