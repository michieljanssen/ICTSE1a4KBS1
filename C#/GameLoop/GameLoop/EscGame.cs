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
        //constructor
        public ExitGame(Game game)
        {
            this.game = game;
            InitializeComponent();
            
        }
       //resume knop pressed event
        private void button1_Click(object sender, EventArgs e)
        {
            Sound.playEffect(Sound.hitmarker);
            game.paused = false;
            this.Close();
        }
        //settings knop pressed event
        private void btn_settings_Click(object sender, EventArgs e)
        {
            //Laat het settingspanel zien en haalt de values van de geluidsvolumes op uit de Settings klasse.
            Sound.playEffect(Sound.hitmarker);
            SettingsPanel.Visible = true;
            trb_Effects.Value = Menutest.Settings.effectsVolume;
            //trb_Music.Value = Menutest.Settings.musicVolume;
        }
        //quit knop pressed event
        private void btn_quit_Click(object sender, EventArgs e)

        {
            //geluid
            Sound.playEffect(Sound.hitmarker);
            //sstuurt je terug naar het hoofd menu tussen 2 threads
            if (game.loop.window.InvokeRequired)
            {
                game.loop.window.Invoke(new MethodInvoker(game.loop.window.MainMenu.BringToFront));

                game.loop.window.Invoke(new MethodInvoker(() => game.loop.window.MainMenu.Visible = true));
            }
            else {
                game.loop.window.MainMenu.BringToFront();
                game.loop.window.MainMenu.Visible = true;
            }
           //scherm wordt wit
            game.loop.window.CreateGraphics().Clear(Color.White);
          //stopped de gameloop
            game.loop.Running = false;
            game.loop.loopThread.Abort();
            this.Close();
        }
        //laad event
        private void ExitGame_Load(object sender, EventArgs e)
        {

        }
        //terug naar het pauze event
        private void btn_back_Click(object sender, EventArgs e)
        {
            Sound.playEffect(Sound.hitmarker);
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
            //Menutest.Settings.musicVolume = trb_Music.Value;
        }

        private void lbl_musicVolume_Click(object sender, EventArgs e)
        {

        }
    }
}
