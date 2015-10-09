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
            this.settings = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.effectsVolumeSlider = new System.Windows.Forms.TrackBar();
            this.musicVolumeSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshRateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SelectLevel = new System.Windows.Forms.Button();
            this.QuitGameButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.mainmenu = new System.Windows.Forms.Panel();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectsVolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeSlider)).BeginInit();
            this.mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Controls.Add(this.saveButton);
            this.settings.Controls.Add(this.label5);
            this.settings.Controls.Add(this.effectsVolumeSlider);
            this.settings.Controls.Add(this.musicVolumeSlider);
            this.settings.Controls.Add(this.label4);
            this.settings.Controls.Add(this.label3);
            this.settings.Controls.Add(this.refreshRateBox);
            this.settings.Controls.Add(this.label2);
            this.settings.Controls.Add(this.button1);
            this.settings.Controls.Add(this.label1);
            this.settings.Controls.Add(this.backButton);
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1264, 681);
            this.settings.TabIndex = 3;
            this.settings.Visible = false;
            this.settings.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(506, 556);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(245, 45);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sound Settings:";
            // 
            // effectsVolumeSlider
            // 
            this.effectsVolumeSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.effectsVolumeSlider.LargeChange = 10;
            this.effectsVolumeSlider.Location = new System.Drawing.Point(628, 450);
            this.effectsVolumeSlider.Maximum = 100;
            this.effectsVolumeSlider.Name = "effectsVolumeSlider";
            this.effectsVolumeSlider.Size = new System.Drawing.Size(247, 45);
            this.effectsVolumeSlider.SmallChange = 5;
            this.effectsVolumeSlider.TabIndex = 9;
            this.effectsVolumeSlider.TickFrequency = 5;
            this.effectsVolumeSlider.Scroll += new System.EventHandler(this.effectsVolumeSlider_Scroll);
            // 
            // musicVolumeSlider
            // 
            this.musicVolumeSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicVolumeSlider.LargeChange = 10;
            this.musicVolumeSlider.Location = new System.Drawing.Point(628, 393);
            this.musicVolumeSlider.Maximum = 100;
            this.musicVolumeSlider.Name = "musicVolumeSlider";
            this.musicVolumeSlider.Size = new System.Drawing.Size(247, 45);
            this.musicVolumeSlider.SmallChange = 5;
            this.musicVolumeSlider.TabIndex = 8;
            this.musicVolumeSlider.TickFrequency = 5;
            this.musicVolumeSlider.Scroll += new System.EventHandler(this.musicVolumeSlider_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Effect Volume:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Music Volume:";
            // 
            // refreshRateBox
            // 
            this.refreshRateBox.AcceptsReturn = true;
            this.refreshRateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshRateBox.Location = new System.Drawing.Point(614, 215);
            this.refreshRateBox.MaxLength = 3;
            this.refreshRateBox.Name = "refreshRateBox";
            this.refreshRateBox.Size = new System.Drawing.Size(100, 44);
            this.refreshRateBox.TabIndex = 5;
            this.refreshRateBox.Text = "0";
            this.refreshRateBox.ClientSizeChanged += new System.EventHandler(this.refreshRateBox_ClientSizeChanged);
            this.refreshRateBox.Enter += new System.EventHandler(this.refreshRateBox_Enter);
            this.refreshRateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.refreshRateBox_KeyPress);
            this.refreshRateBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.refreshRateBox_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "fps";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(554, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit UI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Refresh Rate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1150, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 45);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SelectLevel
            // 
            this.SelectLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectLevel.Location = new System.Drawing.Point(504, 108);
            this.SelectLevel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SelectLevel.Name = "SelectLevel";
            this.SelectLevel.Size = new System.Drawing.Size(238, 65);
            this.SelectLevel.TabIndex = 5;
            this.SelectLevel.Text = "Select Level";
            this.SelectLevel.UseVisualStyleBackColor = true;
            this.SelectLevel.Click += new System.EventHandler(this.SelectLevel_Click);
            // 
            // QuitGameButton
            // 
            this.QuitGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuitGameButton.Location = new System.Drawing.Point(504, 479);
            this.QuitGameButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.QuitGameButton.Name = "QuitGameButton";
            this.QuitGameButton.Size = new System.Drawing.Size(238, 65);
            this.QuitGameButton.TabIndex = 2;
            this.QuitGameButton.Text = "Quit Game";
            this.QuitGameButton.UseVisualStyleBackColor = true;
            this.QuitGameButton.Click += new System.EventHandler(this.QuitGameButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingsButton.Location = new System.Drawing.Point(504, 289);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(238, 65);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // mainmenu
            // 
            this.mainmenu.Controls.Add(this.QuitGameButton);
            this.mainmenu.Controls.Add(this.SettingsButton);
            this.mainmenu.Controls.Add(this.SelectLevel);
            this.mainmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(1264, 681);
            this.mainmenu.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.mainmenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "xXx-gitrekt420-xXx";
            this.Load += new System.EventHandler(this.Main_Load);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectsVolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeSlider)).EndInit();
            this.mainmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button SelectLevel;
        private System.Windows.Forms.Button QuitGameButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel mainmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox refreshRateBox;
        private System.Windows.Forms.TrackBar effectsVolumeSlider;
        private System.Windows.Forms.TrackBar musicVolumeSlider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
    }
}

