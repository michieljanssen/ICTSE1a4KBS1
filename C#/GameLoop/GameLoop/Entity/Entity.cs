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
        private EntityType type;
        private Location pos;
        private int size;

        private int maxHealth;
        private int health;
        

        public Entity(Location pos, EntityType type) {
            this.pos = pos;
            this.type = type;
            size = 32;
        }

        public Entity(int x, int y, EntityType type) {
            this.pos = new Location(x, y);
            this.type = type;
        }

        public virtual void Paint(object sender, PaintEventArgs e)
        {
            Graphics p = e.Graphics;
            p.DrawEllipse(new Pen(Color.Black, 1), pos.X * size, pos.Y * size, size, size);
        }

        public virtual void update() { 
        

        }
    }
}
