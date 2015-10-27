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
                if (keyboard.up && !level.Tiles[Pos.X][Pos.Y-1].solid) { Move(Dir.up); }            // uparrow
                if (keyboard.down && !level.Tiles[Pos.X][Pos.Y+1].solid) { Move(Dir.down); }        // downarrow
                if (keyboard.left && !level.Tiles[Pos.X-1][Pos.Y].solid) { Move(Dir.left); }        //leftarrow
                if (keyboard.right && !level.Tiles[Pos.X +1][Pos.Y].solid) { Move(Dir.right); }     //rightarrow

                //if (keyboard.esc)
                //{
                //if (exit == null)
                //{
                //    ExitGame exit = new ExitGame();
                //    exit.ShowDialog();
                //}
                //}
                turnTimer = 0;
            }
            turnTimer++;
        }
    }
}
