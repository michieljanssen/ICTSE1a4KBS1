namespace Gameconsoleversie
{
    internal class Tegel
    {
        int type;
        public Tegel(int type = 0)
        {
            this.type = type;
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}