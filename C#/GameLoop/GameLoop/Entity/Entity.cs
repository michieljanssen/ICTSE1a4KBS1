using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace GameLoop.Entity
{
  
    class Entity
    {
        public  enum EntityType { player, grunt};

        private float turnTime;
        protected float turnTimer;

        private EntityType type;
        private Location pos;
        protected Level level;
        private int size;

        private int maxHealth;
        private int health;

        public Location Pos { get { return pos; } }
        public float TurnTime { get { return turnTime; } }
        public int Size { get { return size; } }

        public Entity(Location pos, Level level, EntityType type) {
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
            Graphics p = e.Graphics;
            p.FillEllipse(Brushes.Red, pos.X * size, pos.Y * size, size, size);
        }

        public virtual void update() { 
        

        }
    }
}
