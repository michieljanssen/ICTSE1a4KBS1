using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GameLoop
{
    class WallTile : Tile
    {

         //properties geven
        public WallTile(Location init)
            : base(init, TileType.wall, true, Properties.Resources.Wall)
        {
           
        }

    }
}
