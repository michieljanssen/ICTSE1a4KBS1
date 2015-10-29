using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace GameLoop.Entity
{
  
   abstract class Entity
    {
        public  enum EntityType { player, grunt, illuminatie};
        public enum Dir { up,down,left,right};

        private float turnTime;
        protected float turnTimer;

        private EntityType type;
        private Location pos;
        protected Level level;
        private int size;
        private Image sprite;
        private bool flipped = false;
        private Boolean alive;

        public Boolean Alive { get { return alive; } set { alive = value; } }
        public Location Pos { get { return pos; } }
        public float TurnTime { get { return turnTime; } set { turnTime = value; } }
        public int Size { get { return size; } }
        public bool Flipped { get { return flipped; } set { flipped = value; } }
        public Image Sprite { get { return sprite; } }
        public EntityType Type { get { return type; } }


        public Entity(Location pos, Level level, EntityType type, Image sprite) {
            this.alive = true;
            this.sprite = sprite;
            this.pos = pos;
            this.level = level;
            this.type = type;
            size = 32;
            turnTime = 15;
        }
        public Entity(int x, int y, EntityType type) {
            this.pos = new Location(x, y);
            this.type = type;
        }
        
        public virtual void Paint(object sender, PaintEventArgs e)
        {
            if (sprite == null)
            {
                Graphics p = e.Graphics;
                p.FillEllipse(Brushes.Red, pos.X * size, pos.Y * size, size, size);
            }
            else {
                e.Graphics.DrawImage(sprite, Pos.X * Size, Pos.Y * Size);
            }
        }
        public virtual void update(float time) { 
        

        }

        public bool Move(Dir a)
        {
            bool canmove = false;
            switch (a)
            {
                case Dir.up:
                    if (!level.Tiles[pos.X][pos.Y-1].solid) { pos.Y--;  canmove = true; }
                    break;
                case Dir.down:
                    if (!level.Tiles[pos.X][pos.Y + 1].solid) { pos.Y++; canmove = true; }
                    break;
                case Dir.left:
                    if (!level.Tiles[pos.X-1][pos.Y].solid) { pos.X--; canmove = true; }
                    if (Flipped)
                    {
                        this.Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        Flipped = false;
                    }
                    break;
                case Dir.right:
                    if (!level.Tiles[pos.X+1][pos.Y].solid) { pos.X++; canmove = true; }
                    if (!Flipped)
                    {
                        this.Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        Flipped = true;
                    }
                    break;
                default:
                    break;
            }
            return canmove;
        }
    }
}
