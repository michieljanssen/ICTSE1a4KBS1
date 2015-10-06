namespace Gameconsoleversie
{
    internal class Speler
    {
        int locx;
        int locy;
        public Speler(int startx,int starty)
        {
            locx = startx;
            locy = starty;
        }
        public int X
        {
            get { return locx; }
            set { locx = value; }
        }
        public int Y
        {
            get { return locy; }
            set { locy = value; }
        }

        
    }
}