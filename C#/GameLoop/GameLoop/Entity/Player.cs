using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop.Entity
{
    class Player : Entity
    {
        public Player(Location pos, Level level):base(pos, level,EntityType.player){
        
        }
        internal void update(Keyboard keyboard, float time)
        {
            //Console.WriteLine("test");
            if (turnTimer * time >= TurnTime)
            {
                if (keyboard.up && !level.Tiles[Pos.X][Pos.Y-1].solid)
                {
                    Pos.Y--;
                    turnTimer = 0;
                   
                }
                if (keyboard.down && !level.Tiles[Pos.X][Pos.Y + 1].solid)
                {
                    Pos.Y++;
                    turnTimer = 0;
                   
                }
                if (keyboard.left && !level.Tiles[Pos.X -1][Pos.Y ].solid)
                {
                    Pos.X--;
                    turnTimer = 0;
                  
                }
                if (keyboard.right && !level.Tiles[Pos.X +1][Pos.Y].solid)
                {
                    Pos.X++;
                    turnTimer = 0;
                   
                }
                
            }
            turnTimer++;
        }
    }
}
