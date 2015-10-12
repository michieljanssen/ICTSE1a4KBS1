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
        public WallTile(Location init, Level level)
            : base(init, TileType.wall, true, Properties.Resources.Wall, level)
        {
           
        }

    }
}
