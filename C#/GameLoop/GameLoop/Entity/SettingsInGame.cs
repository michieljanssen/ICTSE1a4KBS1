using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menutest;
using GameLoop;

namespace GameLoop.Entity
{
    public partial class SettingsInGame : Form
    {
        public SettingsInGame()
        {
            //trb_MusicVolume.Value = Settings.musicVolume;
            //trb_EffectsVolume.Value = Settings.effectsVolume;
            InitializeComponent();
        }

        private void trb_MusicVolume_Scroll(object sender, EventArgs e)
        {
            Settings.musicVolume = trb_MusicVolume.Value;
        }

        private void trb_EffectsVolume_Scroll(object sender, EventArgs e)
        {
            Settings.effectsVolume = trb_EffectsVolume.Value;
        }

        private void trb_MusicVolume_Validating(object sender, CancelEventArgs e)
        {
            trb_MusicVolume.Value = Settings.musicVolume;
        }
    }
}
