using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop.Entity
{
    class Player : Entity
    {
        public Player(Location pos):base(pos, EntityType.player){
        
        }
        public Player(int x, int y)
            : base(x, y, EntityType.player)
        {
        
        }
    }
}
