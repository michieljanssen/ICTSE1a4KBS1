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
        private int range;

        public Grunt(Location pos, Level level) : base(pos, level, EntityType.grunt) {
            range = 3;
        }

        public override void update()
        {
            //Get the distance of the player to the entity
            int xx = level.Speler.Pos.X - Pos.X;
            int yy = level.Speler.Pos.Y - Pos.Y;
            double r = Math.Sqrt(Math.Abs(xx * xx) + Math.Abs(yy * yy));

            //If player is within range
            if (r < range) {
                if (Pos.X > level.Speler.Pos.X)
                {
                    Pos.X--;
                }
                else if (Pos.X < level.Speler.Pos.X)
                {
                    Pos.X++;
                }
                else
                {
                    if (Pos.Y > level.Speler.Pos.Y)
                    {
                        Pos.Y--;
                    } else if (Pos.Y < level.Speler.Pos.Y)
                    {
                        Pos.Y++;
                    }
                }
            }
            //Action this entity does when the player is not present.
            else
            {
                Random rand = new Random();
                
            }
        }

        public override void Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, Pos.X * Size, Pos.Y * Size, Size, Size);
        }
    }
}
