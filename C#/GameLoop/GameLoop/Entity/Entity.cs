using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace GameLoop.Entity
{
    //abstracte superclasse entity
    abstract class Entity
    {
        //entity types
        public enum EntityType { player, grunt, illuminatie };
        //directie types
        public enum Dir { up, down, left, right };

        //variablen voor het timen van de bewegingen van de entity
        private float turnTime;
        protected float turnTimer;

        //type van dit entity
        private EntityType type;
        //locatie
        private Location pos;
        //level waarin de entity zit
        protected Level level;
        //grote texture entity
        private int size;
        //texture van de entity
        private Image sprite;
        //directie van de texture
        private bool flipped = false;
        //variablen voor de levens status van de entity
        private Boolean alive;


        //properties van de variablen
        public Boolean Alive { get { return alive; } set { alive = value; } }
        public Location Pos { get { return pos; } }
        public float TurnTime { get { return turnTime; } set { turnTime = value; } }
        public int Size { get { return size; } }
        public bool Flipped { get { return flipped; } set { flipped = value; } }
        public Image Sprite { get { return sprite; } }
        public EntityType Type { get { return type; } }

        //contructor
        public Entity(Location pos, Level level, EntityType type, Image sprite)
        {
            this.alive = true;
            this.sprite = sprite;
            this.pos = pos;
            this.level = level;
            this.type = type;
            size = 32;
            turnTime = 15;
        }
        //veroudere contsturctor
        public Entity(int x, int y, EntityType type)
        {
            this.pos = new Location(x, y);
            this.type = type;
        }
        //teken methode
        public virtual void Paint(object sender, PaintEventArgs e)
        {

            if (sprite == null)
            {
                //teken rode circle als plaatje null is
                Graphics p = e.Graphics;
                p.FillEllipse(Brushes.Red, pos.X * size, pos.Y * size, size, size);
            }
            else
            {
                //anders teken plaatje
                e.Graphics.DrawImage(sprite, Pos.X * Size, Pos.Y * Size);
            }
        }
        //update methode
        public virtual void update(float time)
        {


        }
        //methode om te kijken waar de entity naar kan bewegen
        public bool Move(Dir a)
        {
            //return value
            bool canmove = false;
            //switch statement voor richting van bewegen
            switch (a)
            {
                case Dir.up:
                    if (!level.Tiles[pos.X][pos.Y - 1].solid) { pos.Y--; canmove = true; }
                    break;
                case Dir.down:
                    if (!level.Tiles[pos.X][pos.Y + 1].solid) { pos.Y++; canmove = true; }
                    break;
                case Dir.left:
                    if (!level.Tiles[pos.X - 1][pos.Y].solid) { pos.X--; canmove = true; }
                    if (Flipped)
                    {
                        this.Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        Flipped = false;
                    }
                    break;
                case Dir.right:
                    if (!level.Tiles[pos.X + 1][pos.Y].solid) { pos.X++; canmove = true; }
                    if (!Flipped)
                    {
                        this.Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        Flipped = true;
                    }
                    break;
                default:
                    break;
            }

            //return return value
            return canmove;
        }
    }
}
