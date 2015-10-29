﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GameLoop
{
   class StartTile : Tile
    { 
        //vloer voor onder de kid
        private Image floor;

        //properties geven
        public StartTile(Location init, Image floor, Level level)
            : base(init, TileType.floor, false, Properties.Resources.floor_tile_texture, level)
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
