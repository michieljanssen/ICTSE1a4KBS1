using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop.Entity
{
    class Player : Entity
    {
        public Player(Location pos, Level level):base(pos, level,EntityType.player, Properties.Resources.dank_kid)
        {
        
        }
        internal void update(Keyboard keyboard, float time)
        {
            //Console.WriteLine("test");
            if (turnTimer * time >= TurnTime)
            {
                if (keyboard.up && !level.Tiles[Pos.X][Pos.Y-1].solid)
                {
                    Sound.playEffect(Sound.hitmarker);
                    Pos.Y--;
                    turnTimer = 0;
                   
                }
                if (keyboard.down && !level.Tiles[Pos.X][Pos.Y + 1].solid)
                {
                    Sound.playEffect(Sound.hitmarker);
                    Pos.Y++;
                    turnTimer = 0;
                   
                }
                if (keyboard.left && !level.Tiles[Pos.X -1][Pos.Y ].solid)
                {
                    Sound.playEffect(Sound.hitmarker);
                    Pos.X--;
                    turnTimer = 0;
                    if (this.Flipped)
                    {
                        this.Flipped = false;
                        this.Sprite.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);
                    }
                  
                }
                if (keyboard.right && !level.Tiles[Pos.X +1][Pos.Y].solid)
                {
                    Sound.playEffect(Sound.hitmarker);
                    Pos.X++;
                    turnTimer = 0;
                    if (!this.Flipped)
                    {
                        this.Flipped = true;
                        this.Sprite.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);
                    }

                }
                
                //if (keyboard.esc)
                //{
                    //if (exit == null)
                    //{
                    //    ExitGame exit = new ExitGame();
                    //    exit.ShowDialog();
                    //}
                //}
                Sound.playEffect(Sound.hitmarker);
            }
            turnTimer++;
        }
    }
}
