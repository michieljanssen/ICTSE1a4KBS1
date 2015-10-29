using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop.Entity
{ class Illuminatie : Entity
    {
        public Illuminatie(Location init, Level level):base( init, level, EntityType.illuminatie, Properties.Resources.illerminaty ){
    
        }

        public override void  update(float time)
        {
            //player collsion
            if (Pos.Compareto(level.Speler.Pos))
            {
                //set player alive status to false
                level.Speler.Alive = false;

            }
        }      

    }
}
