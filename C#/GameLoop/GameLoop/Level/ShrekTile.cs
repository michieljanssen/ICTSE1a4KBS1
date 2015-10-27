using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameLoop
{
    class ShrekTile : Tile  //subklasse van Tile klasse
    {

        //vloer voor onder de shrek
        private Image floor;

        private Level map;
        private Game game;
        public ShrekTile(Location init, Image floor, Level level, Game game)
            : base(init, TileType.shrek, false, Properties.Resources.dank_shrek, level)
        {
            this.floor = floor;
            this.game = game;
        }


        internal override void Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //tekenen overriden en custom tekenen
            e.Graphics.DrawImage(floor, Pos.X * Size, Pos.Y * Size);
            e.Graphics.DrawImage(Texture, Pos.X * Size, Pos.Y * Size);
        }
        //Checks for player
        public override void Update() {
            //Shuts down if player is equal to this tile
            if (Pos.Compareto(level.Speler.Pos)) {
                var result = MessageBox.Show("Next level?", "You won!",
                                 MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    XDocument level2 = XDocument.Parse(Properties.Resources.Level2);
                    this.level.Game.changeLevel(level2);
                   
                }
                else if (result == DialogResult.No)
                {
                    if (game.loop.window.InvokeRequired)
                    {
                        game.loop.window.Invoke(new MethodInvoker(game.loop.window.MainMenu.BringToFront));
                        game.loop.window.Invoke(new MethodInvoker(() => game.loop.window.MainMenu.Visible = true));
                    }
                    game.loop.window.CreateGraphics().Clear(Color.White);
                    game.loop.Running = false;
                    game.loop.loopThread.Abort();
                }
                    //Environment.Exit(0);


            }
        }
    }
}
