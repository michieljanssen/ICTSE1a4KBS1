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
           // SettingsInGame settings = new SettingsInGame();
           // settings.ShowDialog();
           // this.Close();
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
    }
}
