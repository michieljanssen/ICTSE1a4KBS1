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
                float horz = level.Speler.Pos.X - Pos.X;
                float vert = level.Speler.Pos.Y - Pos.Y;
                float r = (float) Pos.Distanceto(level.Speler.Pos);
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

                    if (Math.Abs(horz) > Math.Abs(vert))
                    {
                        if (horz<0)
                        {
                            if (!this.Move(Dir.left) && vert<0)
                            {
                                this.Move(Dir.up);
                            }
                            else if(vert>0)
                            {
                                this.Move(Dir.down);
                            }
                            //turnTimer = 0;
                        }
                        else if (horz>0)
                        {
                            if (!this.Move(Dir.right) && vert < 0)
                            {
                                this.Move(Dir.up);
                            }
                            else if(vert > 0)
                            {
                                this.Move(Dir.down);
                            }
                        }
                    }
                    else
                    {
                        if (vert<0)
                        {
                            if(!this.Move(Dir.up) && horz < 0)
                            {
                                this.Move(Dir.left);
                            }
                            else if(horz>0)
                            {
                                this.Move(Dir.right);
                            }
                            
                        }
                        else if (vert>0)
                        {
                            if (!this.Move(Dir.down) && horz < 0)
                            {
                                this.Move(Dir.left);
                            }
                            else if (horz > 0)
                            {
                                this.Move(Dir.right);
                            }

                        }
                    }
                }
                //Action this entity does when the player is not present.
                else
                {
                    int dx = level.rand.Next(4);
                    switch (dx)
                    {
                        case 0:
                            c0:
                            if (!Move(Dir.up)) { goto c1; }
                            break;
                        case 1:
                            c1:
                            if (!Move(Dir.down)) { goto c2; }
                            break;
                        case 2:
                            c2:
                            if (!Move(Dir.left)) { goto c3; }
                            break;
                        case 3:
                            c3:
                            if (!Move(Dir.right)) { goto c0; }
                            break;
                        default:
                            break;
                    }
                    //turnTimer = 0;

                }
                turnTimer = 0;
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
