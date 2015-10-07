namespace GameV2
{
    internal class Tiletype
    {
        int typeint;
        string typestring;
        public Tiletype(int type=0)
        {
            typeint = type;
            switch (typeint)
            {
                default:
                    throw new System.ArgumentNullException();                    
                case 0:
                    typestring = "Floor";
                    break;
                case 1:
                    typestring = "Wall";
                    break;
                case 2:
                    typestring = "Start";
                    break;
                case 3:
                    typestring = "End";
                    break;
            }
        }
        public int Type
        {
            get { return typeint; }
            set { typeint = value; }
        }
        public override string ToString()
        {
            return typestring;
        }
    }
}