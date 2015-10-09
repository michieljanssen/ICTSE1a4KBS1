using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop
{
    class Location  //Klasse met X en Y positie
    {
        int x;
        int y;
        //default constructor
        public Location(int posx,int posy)
        {
            x = posx;
            y = posy;
        }

        //properties x
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        //properties Y
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return "("+x+"|"+y+")"; 
        }
        public bool Compareto(Location second)
        {
            if(this.X==second.X && this.Y == second.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
