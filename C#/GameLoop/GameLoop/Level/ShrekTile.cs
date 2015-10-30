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
    public class ShrekTile : Tile  //subklasse van Tile klasse
    {       
        //vloer voor onder de shrek
        private Image floor;
        public ShrekTile(Location init, Image floor, Level level)
            : base(init, TileType.shrek, false, Properties.Resources.dank_shrek, level)
        {
            this.floor = floor;
            
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
                this.level.Game.nextLevel();
            }
        }
    }
}
