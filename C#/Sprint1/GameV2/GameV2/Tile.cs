using System;
using System.Windows.Forms;
using System.Drawing;

namespace GameV2
{
    
    internal class Tile
    {
        private Location pos;   //opslaan van de locatie van de tegel
        private Tiletype tiletype;   //opslaan van het type tegel
        private int tilesize;
        public Tile(Location init,int size=32,int tile = 0)
        {
            pos = init; //pos waarde geven
            tiletype = new Tiletype(tile); //type aangeven, standaard is vloer
            tilesize = size; // default = 32 pixels
        }
        public Tiletype Type
        {
            get { return tiletype; }
            set { tiletype = value; }
        }
        public int Size
        {
            get { return tilesize; }
            set { tilesize = value; }
        }
        public override string ToString()
        {
            return pos.ToString() + " | "+tiletype.ToString();
        }
        public Location Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        internal void Paint(object sender, PaintEventArgs e)
        {
            Pen blackoutline = new Pen(Color.Black, 1);
            Brush fill;
            Image texture;
            texture = Properties.Resources.floor_tile_texture;
            e.Graphics.DrawImage(texture, pos.X * tilesize, pos.Y * tilesize);

            switch (tiletype.Type)
            {
                default:
                    fill = new SolidBrush(Color.Red);
                    break;
                case 0:
                    texture = Properties.Resources.floor_tile_texture;
                    e.Graphics.DrawImage(texture, pos.X * tilesize, pos.Y * tilesize);
                    break;
                case 1:
                    texture = Properties.Resources.Wall;
                    e.Graphics.DrawImage(texture, pos.X * tilesize, pos.Y * tilesize-10);
                    break;
                case 2:
                    texture = Properties.Resources.dank_kid;
                    e.Graphics.DrawImage(texture, pos.X * tilesize, pos.Y * tilesize);
                    break;
                case 3:
                    texture = Properties.Resources.dank_shrek;
                    e.Graphics.DrawImage(texture, pos.X * tilesize, pos.Y * tilesize);
                    break;
            }
            
        }
    }
}