using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using GameV2;

namespace GameLoop.Entity
{
  
    class Entity
    {
        Location pos;
        int size;
        public Entity(Location pos) {
            this.pos = pos;
            size = 32;
        }

        public Entity(int x, int y) {
            this.pos = new Location(x, y);
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
