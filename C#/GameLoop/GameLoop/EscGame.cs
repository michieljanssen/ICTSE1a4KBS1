using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameLoop
{
    public partial class ExitGame : Form
    {
        private Game game;

        public ExitGame(Game game)
        {
            this.game = game;
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            game.paused = false;
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            //Laat het settingspanel zien en haalt de values van de geluidsvolumes op uit de Settings klasse.
            SettingsPanel.Visible = true;
            trb_Effects.Value = Menutest.Settings.effectsVolume;
            trb_Music.Value = Menutest.Settings.musicVolume;
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            if (game.loop.window.InvokeRequired)
            {
                game.loop.window.Invoke(new MethodInvoker(game.loop.window.MainMenu.BringToFront));

                game.loop.window.Invoke(new MethodInvoker(() => game.loop.window.MainMenu.Visible = true));
            }
            else {
                game.loop.window.MainMenu.BringToFront();
                game.loop.window.MainMenu.Visible = true;
            }
           
            game.loop.window.CreateGraphics().Clear(Color.White);
          
            game.loop.Running = false;
            game.loop.loopThread.Abort();
            this.Close();
        }

        private void ExitGame_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = false;
        }

        private void trb_Effects_Scroll(object sender, EventArgs e)
        {
            //Verandert de value voor effects volume in de settings klasse
            Menutest.Settings.effectsVolume = trb_Effects.Value;
        }

        private void trb_musicVolume_Scroll(object sender, EventArgs e)
        {
            //Verandert de value voor music volume in de settings klasse
            Menutest.Settings.musicVolume = trb_Music.Value;
        }
    }
}
