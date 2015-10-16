namespace GameLoop.Entity
{
    partial class SettingsInGame
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
            this.lbl_SoundSettings = new System.Windows.Forms.Label();
            this.lbl_MusicVolume = new System.Windows.Forms.Label();
            this.lbl_EffectsVolume = new System.Windows.Forms.Label();
            this.trb_MusicVolume = new System.Windows.Forms.TrackBar();
            this.trb_EffectsVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_EffectsVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SoundSettings
            // 
            this.lbl_SoundSettings.AutoSize = true;
            this.lbl_SoundSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_SoundSettings.Location = new System.Drawing.Point(63, 19);
            this.lbl_SoundSettings.Name = "lbl_SoundSettings";
            this.lbl_SoundSettings.Size = new System.Drawing.Size(243, 37);
            this.lbl_SoundSettings.TabIndex = 0;
            this.lbl_SoundSettings.Text = "Sound Settings:";
            // 
            // lbl_MusicVolume
            // 
            this.lbl_MusicVolume.AutoSize = true;
            this.lbl_MusicVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_MusicVolume.Location = new System.Drawing.Point(63, 87);
            this.lbl_MusicVolume.Name = "lbl_MusicVolume";
            this.lbl_MusicVolume.Size = new System.Drawing.Size(227, 37);
            this.lbl_MusicVolume.TabIndex = 1;
            this.lbl_MusicVolume.Text = "Music Volume:";
            // 
            // lbl_EffectsVolume
            // 
            this.lbl_EffectsVolume.AutoSize = true;
            this.lbl_EffectsVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_EffectsVolume.Location = new System.Drawing.Point(63, 221);
            this.lbl_EffectsVolume.Name = "lbl_EffectsVolume";
            this.lbl_EffectsVolume.Size = new System.Drawing.Size(241, 37);
            this.lbl_EffectsVolume.TabIndex = 2;
            this.lbl_EffectsVolume.Text = "Effects Volume:";
            // 
            // trb_MusicVolume
            // 
            this.trb_MusicVolume.Location = new System.Drawing.Point(70, 148);
            this.trb_MusicVolume.Maximum = 100;
            this.trb_MusicVolume.Name = "trb_MusicVolume";
            this.trb_MusicVolume.Size = new System.Drawing.Size(220, 45);
            this.trb_MusicVolume.SmallChange = 5;
            this.trb_MusicVolume.TabIndex = 10;
            this.trb_MusicVolume.TickFrequency = 10;
            this.trb_MusicVolume.Scroll += new System.EventHandler(this.trb_MusicVolume_Scroll);
            // 
            // trb_EffectsVolume
            // 
            this.trb_EffectsVolume.Location = new System.Drawing.Point(70, 281);
            this.trb_EffectsVolume.Maximum = 100;
            this.trb_EffectsVolume.Name = "trb_EffectsVolume";
            this.trb_EffectsVolume.Size = new System.Drawing.Size(220, 45);
            this.trb_EffectsVolume.SmallChange = 5;
            this.trb_EffectsVolume.TabIndex = 11;
            this.trb_EffectsVolume.TickFrequency = 10;
            this.trb_EffectsVolume.Scroll += new System.EventHandler(this.trb_EffectsVolume_Scroll);
            // 
            // SettingsInGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 387);
            this.Controls.Add(this.trb_EffectsVolume);
            this.Controls.Add(this.trb_MusicVolume);
            this.Controls.Add(this.lbl_EffectsVolume);
            this.Controls.Add(this.lbl_MusicVolume);
            this.Controls.Add(this.lbl_SoundSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsInGame";
            this.Text = "SettingsInGame";
            ((System.ComponentModel.ISupportInitialize)(this.trb_MusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_EffectsVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SoundSettings;
        private System.Windows.Forms.Label lbl_MusicVolume;
        private System.Windows.Forms.Label lbl_EffectsVolume;
        private System.Windows.Forms.TrackBar trb_MusicVolume;
        private System.Windows.Forms.TrackBar trb_EffectsVolume;
    }
}