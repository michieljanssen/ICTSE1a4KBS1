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

        //private Level map;
        //private Game game;
        public ShrekTile(Location init, Image floor, Level level, Game game)
            : base(init, TileType.shrek, false, Properties.Resources.dank_shrek, level)
        {
            this.floor = floor;
            //this.game = game;
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
                Environment.Exit(0);

                //XDocument level2 = XDocument.Parse(@"Resources\Level2.xml");
                //map = new Level(level2, game);

            }
        }
    }
}
