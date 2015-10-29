using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop
{
    public class Location  //Klasse met X en Y positie
    {
        int x;
        int y;
        //properties
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        // constructors
        public Location(int posx,int posy)
        {
            x = posx;
            y = posy;
        }
        public Location(Location location)
        {
            x = location.x;
            y = location.y;
        }

        public bool Compareto(Location second)
        {
            if(this.X==second.X && this.Y == second.Y) { return true; } else { return false;}
        }

        public double Distanceto(Location location)
        {
            int xb = location.X;
            int yb = location.Y;
            int horz = Math.Abs(x - xb);
            int vert = Math.Abs(y- yb);
            return Math.Sqrt(horz * horz + vert * vert);
        }

        public void Move(int x,int y)
        {
            this.x += x;
            this.y += y;
        }

        public override string ToString()
        {
            return ((string)"(" + x + "|" + y + ")");
        }
    }
}
