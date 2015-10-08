using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameLoop
{
    internal class Level
    {
        private Location gridSize; //hergebruik van de Locatieklasse om de afmetingen van het rooster
        private Tile[][] tiles;   //Array of all the tiles in the game
        private Location start;
        private Location eind;

        public Level(Location gridsize, Location s, Location e, int size = 32)
        {
            //Setup of the gridsize
            gridSize = new Location(gridsize.X + 2, gridsize.Y + 2); //gridsize wordt vergroot met twee voor muren
            //horizontal rows are initialized
            tiles = new Tile[gridSize.X][];
            for (int y = 0; y < gridSize.X; y++)
            {
                //vertical cells are initialized
                tiles[y] = new Tile[gridSize.Y];
            }

            //initiate start and end point
            start = s;
            eind = e;

            //setting up the floorplan
            for (int xloc = 0; xloc < gridSize.X; xloc++)
            {
                for (int yloc = 0; yloc < gridSize.Y; yloc++)
                {
                    if (yloc == 0 || yloc == gridSize.Y - 1 || xloc == 0 || xloc == gridSize.X - 1)
                    {
                        tiles[xloc][yloc] = new WallTile(new Location(xloc, yloc));   //assign the outer walls
                    }
                    else
                    {
                        //assign floor
                        tiles[xloc][yloc] = new FloorTile(new Location(xloc, yloc));
                    }

                    if (new Location(xloc, yloc).Compareto(start))
                    {
                        //assign start location
                        tiles[xloc][yloc] = new KidTile(new Location(xloc, yloc), Properties.Resources.floor_tile_texture);
                    }
                    if (new Location(xloc, yloc).Compareto(eind))
                    {
                        //assign end location
                        tiles[xloc][yloc] = new ShrekTile(new Location(xloc, yloc), Properties.Resources.floor_tile_texture);
                    }
                }
            }
        }
        public Location Start
        {
            get { return start; }
            set { start = value; }
        }
        //Paint's the level
        internal void Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                for (int u = 0; u < tiles[i].Length; u++)
                {
                    tiles[i][u].Paint(sender, e);
                }
            }
        }
    }
}
