namespace GameV2
{
    
    internal class Tile
    {
        private Location pos;   //opslaan van de locatie van de tegel
        private Tiletype tiletype;   //opslaan van het type tegel
        private int tilesize;
        public Tile(Location init,int size=32,int tile = 0)
        {
            pos = init; //pos waarde geven
            tiletype = new Tiletype(tile); //type aangeven, standaard is vloer
            tilesize = size; // default = 32 pixels
        }
        public Tiletype Type
        {
            get { return tiletype; }
            set { tiletype = value; }
        }
        public int Size
        {
            get { return tilesize; }
            set { tilesize = value; }
        }
        public override string ToString()
        {
            return pos.ToString() + " | "+tiletype.ToString();
        }
        public Location Pos
        {
            get { return pos; }
            set { pos = value; }
        }
    }
}