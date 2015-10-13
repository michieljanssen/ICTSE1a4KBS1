using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLoop
{
    
    internal abstract class Tile
    {   
        public enum TileType { wall, floor, kid, shrek }; //tiletypes
        private TileType type; // huidige type van tile
        private Location pos;   //opslaan van de locatie van de tegel
        private int tilesize;   //Displayformaat van de tile
        private Image texture; // de sprite/texture van de tile
        public Boolean solid;   //of de tile doordringbaar is
        protected Level level;  //level waar de tile inzit
        
        //Property methodes
        public Image Texture { get { return texture;} set { texture = value; } }
        public TileType Type{ get { return type; } set { type = value; } }
        public int Size { get { return tilesize; } set { tilesize = value; } }
        public Location Pos{ get { return pos; } set { pos = value; } }

        public Tile(Location init, TileType type, Boolean solid, Image texture, Level level)
        {
            //variabelen initalizeren
            this.level = level;
            this.solid = solid;
            this.texture = texture;
            this.pos = init;
            this.type = type;
            this.tilesize = 32;
        }

        internal virtual void Paint(object sender, PaintEventArgs e)
        {         
            //teken texture op de goeie locatie
           e.Graphics.DrawImage(texture, pos.X * tilesize, pos.Y * tilesize);
        }

        public virtual void Update()
        {

        }

        public override string ToString()
        {
            return pos.ToString() + " | "+type.ToString();
        }

    }
}