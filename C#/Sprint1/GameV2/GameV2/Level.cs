namespace GameV2
{
    internal class Level
    {
        private Location gridSize; //hergebruik van de Locatieklasse om de afmetingen van het rooster
        private Tile[][] tiles;   //Array of all the tiles in the game
        private Location start;
        private Location eind;

        public Level(Location gridsize,Location s,Location e)
        {   
            //Setup of the gridsize
            gridSize = new Location(gridsize.X+2,gridsize.Y+2); //gridsize wordt vergroot met twee voor muren
            //horizontal rows are initialized
            tiles = new Tile[gridSize.X][];
            for (int y = 0; y < gridSize.X; y++)
            {
                //vertical cells are initialized
                tiles[y] = new Tile[gridSize.Y];
            }

            //initiate start and end point
            start = s;
            eind = e;

            //setting up the floorplan
            for (int xloc = 0; xloc < gridSize.X; xloc++)
            {
                for (int yloc = 0; yloc < gridSize.Y; yloc++)
                {
                    tiles[xloc][yloc] = new Tile(new Location(xloc, yloc)); //assign all tiles and turn them into floors
                    if(yloc ==0 ||yloc== gridSize.Y - 1 || xloc == 0 || xloc == gridSize.X - 1)
                    {
                        tiles[xloc][yloc].Type = new Tiletype(1);   //assign the outer walls
                    }
                    //Place start location
                    if (tiles[xloc][yloc].Pos.Compareto(start))
                    {
                        tiles[xloc][yloc].Pos = start;
                    }
                    //Place end location
                    if (tiles[xloc][yloc].Pos.Compareto(eind))
                    {
                        tiles[xloc][yloc].Pos = eind;
                    }
                }
            }

        }
    }
}