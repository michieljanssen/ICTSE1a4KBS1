﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GameLoop
{
    class ShrekTile : Tile
    {

        //vloer voor onder de shrek
        private Image floor;

        public ShrekTile(Location init, Image floor)
            : base(init, TileType.shrek, false, Properties.Resources.dank_shrek)
        {
            this.floor = floor;
        }


        internal override void Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //tekenen overriden en custom tekenen
            e.Graphics.DrawImage(floor, Pos.X * Size, Pos.Y * Size);
            e.Graphics.DrawImage(Texture, Pos.X * Size, Pos.Y * Size);
        }
    }
}
