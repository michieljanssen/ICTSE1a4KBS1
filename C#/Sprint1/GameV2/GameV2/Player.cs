using System;
using System.Windows.Forms;
using System.Drawing;

namespace GameV2
{
    internal class Player
    {
        Location pos;
        int size;
        public Player(Location init,int s =32)
        {
            pos = init;
            size = s;
        }

        internal void Paint(object sender, PaintEventArgs e)
        {
            Graphics p = e.Graphics;
            p.DrawEllipse(new Pen(Color.Black, 1), pos.X * size, pos.Y * size, size, size);
        }
    }
}