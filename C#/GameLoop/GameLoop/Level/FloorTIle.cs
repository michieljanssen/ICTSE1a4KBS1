using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace GameLoop
{
    class FloorTile : Tile
    {
        //properties geven
        public FloorTile(Location init, Level level) : base(init, TileType.floor, false, Properties.Resources.floor_tile_texture, level) { 
        
        }
       
    }
}
