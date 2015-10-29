using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop.Entity
{
    class Player : Entity
    {
        public Player(Location pos, Level level)
            : base(pos, level, EntityType.player, Properties.Resources.dank_kid)
        {

        }
        internal void update(Keyboard keyboard, float time)
        {
            //checked of het tijd is voor de speler om te bewegen
            if (turnTimer * time >= TurnTime)
            {
                //checked of de speler kan bewegen
                if (keyboard.up && !level.Tiles[Pos.X][Pos.Y - 1].solid)
                {
                    //speelt geluid af
                    Sound.playEffect(Sound.hitmarker);
                    //beweegt speler
                    Pos.Y--;
                    //reset timer
                    turnTimer = 0;

                }
                //checked of de speler kan bewegen
                if (keyboard.down && !level.Tiles[Pos.X][Pos.Y + 1].solid)
                {
                    //speelt geluid af
                    Sound.playEffect(Sound.hitmarker);
                    //beweegt speler
                    Pos.Y++;
                    //reset timer
                    turnTimer = 0;

                }
                //checked of de speler kan bewegen
                if (keyboard.left && !level.Tiles[Pos.X - 1][Pos.Y].solid)
                {
                    //speelt geluid af
                    Sound.playEffect(Sound.hitmarker);
                    //beweegt speler
                    Pos.X--;
                    //reset timer
                    turnTimer = 0;
                    
                    if (this.Flipped)
                    {//flipped de texture
                        this.Flipped = false;
                        this.Sprite.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);
                    }

                }
                //checked of de speler kan bewegen
                if (keyboard.right && !level.Tiles[Pos.X + 1][Pos.Y].solid)
                {
                    //speelt geluid af
                    Sound.playEffect(Sound.hitmarker);
                    //beweegt speler
                    Pos.X++;
                    //reset timer
                    turnTimer = 0;
                    if (!this.Flipped)
                    {//flipped de texture
                        this.Flipped = true;
                        this.Sprite.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);
                    }

                }

            }
            //update de timer
            turnTimer++;
        }
    }
}
