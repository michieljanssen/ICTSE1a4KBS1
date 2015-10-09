using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GameLoop.Entity
{
    class Grunt : Entity
    {
        public Grunt(Location pos, Level level) : base(pos, level, EntityType.grunt) { 
        
        }

        public override void update()
        {
            Random rand = new Random();
            int x = rand.Next(5) - 2;
            int y = rand.Next(5) - 2;
            Pos.X += x;
            Pos.Y += y;
        }

        public override void Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, Pos.X * Size, Pos.Y * Size, Size, Size);
        }
    }
}
