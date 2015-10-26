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
        /// <summary>
        /// This class allows you to store the x and y coordinates of an entity/tile
        /// </summary>
        /// <param name="posx">the x position</param>
        /// <param name="posy">the y position</param>
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
        /// <summary>
        /// Display the Coördinates of location in a string.
        /// </summary>
        /// <returns>returns a string</returns>
        public override string ToString()
        {
            return ((string)"("+x+"|"+y+")"); 
        }
        /// <summary>
        /// Checks to see if two locations have the same coördinates
        /// </summary>
        /// <param name="second">the second location you have to compare to</param>
        /// <returns>Returns a boolean value</returns>
        public bool Compareto(Location second)
        {
            if(this.X==second.X && this.Y == second.Y) { return true; } else { return false;}
        }
        /// <summary>
        /// Returns the length of the distance between two Locations
        /// </summary>
        /// <param name="second">The other Location you have to compare to.</param>
        /// <returns>returns a double value</returns>
        public double Distanceto(Location second)
        {
            int xb = second.X;
            int yb = second.Y;
            int a = Math.Abs(x - xb);
            int b = Math.Abs(y- yb);
            return Math.Sqrt(a * a + b * b);
        }
    }
}
