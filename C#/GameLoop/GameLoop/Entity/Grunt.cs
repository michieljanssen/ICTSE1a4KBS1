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
        private Boolean following = false;
        private int startRange, fRange;


        public Grunt(Location pos, Level level)
            : base(pos, level, EntityType.grunt, Properties.Resources.Man_slayer)
        {
            startRange = 5;
            fRange = 10;
            TurnTime = 30;

        }

        public override void update(float time)
        {
            if (turnTimer * time >= TurnTime)
            {
                //Get the distance of the player to the entity
                float xx = Math.Abs(level.Speler.Pos.X - Pos.X);
                float yy = Math.Abs(level.Speler.Pos.Y - Pos.Y);
                float r = (float)Math.Sqrt(xx*xx + yy*yy);
                if (r < startRange)
                { //if player comes to close start tracking (range increases)
                    following = true;
                }
                else if (r > fRange)
                { //if player is out of tracking range, stop tracking
                    following = false;
                }

                //If player is within range
                if (r < startRange || (r < fRange && following))
                {
                    if (xx > yy)
                    {
                        if (Pos.X > level.Speler.Pos.X && !level.Tiles[Pos.X - 1][Pos.Y].solid)
                        {
                            Pos.X--;
                            turnTimer = 0;
                        }
                        else if (Pos.X < level.Speler.Pos.X && !level.Tiles[Pos.X + 1][Pos.Y].solid)
                        {
                            Pos.X++;
                            turnTimer = 0;
                        }
                    }
                    else
                    {
                        if (Pos.Y > level.Speler.Pos.Y && !level.Tiles[Pos.X][Pos.Y - 1].solid)
                        {
                            Pos.Y--;
                            turnTimer = 0;
                        }
                        else if (Pos.Y < level.Speler.Pos.Y && !level.Tiles[Pos.X][Pos.Y + 1].solid)
                        {
                            Pos.Y++;
                            turnTimer = 0;
                        }
                    }
                }
                //Action this entity does when the player is not present.
                else
                {
                    int dx = level.rand.Next(3) - 1;

                    int dy = level.rand.Next(3) - 1;
                    if (!level.Tiles[Pos.X + dx][Pos.Y].solid)
                    {
                        Pos.X += dx;
                        turnTimer = 0;
                    }
                    if (!level.Tiles[Pos.X][Pos.Y + dy].solid)
                    {
                        Pos.Y += dy;
                        turnTimer = 0;
                    }

                }
            }
            turnTimer++;

            //player collsion
            if (Pos.Compareto(level.Speler.Pos))
            {
                //set player alive status to false
                level.Speler.Alive = false;

            }

        }




    }
}
