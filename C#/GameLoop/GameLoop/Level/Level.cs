using System;
using System.Drawing;
using System.Windows.Forms;
using GameLoop.Entity;
using System.Collections;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Menutest;

namespace GameLoop
{
    internal class Level
    {
        private Game game;
        
        private XDocument file;

        private Location gridSize; //hergebruik van de Locatieklasse om de afmetingen van het rooster
        private Tile[][] tiles;   //Array of all the tiles in the game
        private Location start;
        private Location eind;
        private Player speler;

        public Tile[][] Tiles { get { return tiles; } }
        public Location GridSize { get { return gridSize; } }
        private ArrayList entities;
        public Game Game { get { return game; } }
        public Player Speler { get { return speler; } }

        public Random rand;

        public Location Start
        {
            get { return start; }
            set { start = value; }
        }

        public Level(Location gridsize, Location s, Location e, Game game, int size = 32)
        {
         
            this.game = game;
            //Setup of the gridsize
            gridSize = new Location(gridsize.X + 2, gridsize.Y + 2); //gridsize wordt vergroot met twee voor muren
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
                    if (yloc == 0 || yloc == gridSize.Y - 1 || xloc == 0 || xloc == gridSize.X - 1)
                    {
                        tiles[xloc][yloc] = new WallTile(new Location(xloc, yloc), this);   //assign the outer walls
                    }
                    else
                    {
                        //assign floor
                        tiles[xloc][yloc] = new FloorTile(new Location(xloc, yloc), this);
                    }

                    if (new Location(xloc, yloc).Compareto(start))
                    {
                        //assign start location
                        tiles[xloc][yloc] = new StartTile(new Location(xloc, yloc), Properties.Resources.floor_tile_texture, this);
                    }
                    if (new Location(xloc, yloc).Compareto(eind))
                    {
                        //assign end location
                        tiles[xloc][yloc] = new ShrekTile(new Location(xloc, yloc), Properties.Resources.floor_tile_texture, this);
                    }
                }
            }
            rand = new Random();

            speler = new Player(Start, this);
            entities = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                entities.Add(new Grunt(new Location(rand.Next(gridsize.X), rand.Next(gridsize.Y)), this));
                entities.Add(new Illuminatie(new Location(rand.Next(gridsize.X), rand.Next(gridsize.Y)), this));

            }

        }

        public Level(XmlReader xml, Game game)
        {
            this.game = game;
            this.file =XDocument.Load(xml);
            load(file);
        }

        public Level(XDocument xdoc, Game game)
        {
            this.game = game;
            this.file = xdoc;
            load(xdoc);
        }

        public void load(XDocument xdoc)
        {
            //Sound.playMusic(Sound.skeleton);
            game.keyboard.releaseAllKeys();
            XmlReader xml = xdoc.CreateReader();
            xml.MoveToAttribute(1);
            //xml.move
            rand = new Random();
            entities = new ArrayList();

            Location start = new Location(0, 0);
            int width = 0, height = 0;

            //    xml.
            while (xml.Read())
            {
                if (xml.NodeType == XmlNodeType.Element && xml.Name == "Size")
                {

                    xml.ReadToFollowing("Width");
                    width = xml.ReadElementContentAsInt();
                    //xml.ReadToFollowing("Height");
                    height = xml.ReadElementContentAsInt();

                    tiles = new Tile[width][];
                    for (int y = 0; y < width; y++)
                    {
                        //vertical cells are initialized
                        tiles[y] = new Tile[height];
                    }

                    for (int x = 0; x < tiles.Length; x++)
                    {
                        for (int y = 0; y < tiles[x].Length; y++)
                        {
                            tiles[x][y] = new FloorTile(new Location(x, y), this);
                        }
                    }

                }
                else if (xml.NodeType == XmlNodeType.Element)
                {
                    String name = xml.Name;

                    int x = Convert.ToInt32(xml.GetAttribute("x"));
                    int y = Convert.ToInt32(xml.GetAttribute("y"));

                    switch (name)
                    {
                        case "Muur":
                            tiles[x][y] = new WallTile(new Location(x, y), this);
                            break;
                        case "Vloer":
                            tiles[x][y] = new FloorTile(new Location(x, y), this);
                            break;
                        case "Shrek":
                            tiles[x][y] = new ShrekTile(new Location(x, y), Properties.Resources.floor_tile_texture, this);
                            break;
                        case "Kid":
                            tiles[x][y] = new StartTile(new Location(x, y), Properties.Resources.floor_tile_texture, this);
                            start = new Location(x, y);
                            break;
                        case "Grunt":
                            entities.Add(new Grunt(new Location(x, y), this));
                            break;
                        case "Illuminatie":
                            entities.Add(new Illuminatie(new Location(x, y), this));
                            break;
                    }
                }
                speler = new Player(start, this);
            }
        }

        //Paint's the level
        internal void Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                if (tiles[i] != null) {
                    for (int u = 0; u < tiles[i].Length; u++)
                    {
                        if (tiles[i][u] != null)
                        {
                            tiles[i][u].Paint(sender, e);
                        }
                    }
                }
            }
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities.ToArray()[i] is Entity.Entity)
                {
                    Entity.Entity enitity = (Entity.Entity)entities.ToArray()[i];
                    enitity.Paint(sender, e);
                }
            }
            speler.Paint(sender, e);
        }

        internal void update(Keyboard keyboard, float time)
        {
            //checkt of de speler nog leeft
            if (!speler.Alive) {
                //speelt geluid af

                Sound.playEffect(Sound.headshot);
                var result = MessageBox.Show("Try again?", "You died!",
                                 MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    load(file); //herlaadt het spel
                }
                else if (result == DialogResult.No)
                {
                   
                   
                    if (game.loop.window.InvokeRequired)
                    {
                        game.loop.window.Invoke(new MethodInvoker(game.loop.window.MainMenu.BringToFront));
                      
                         game.loop.window.Invoke(new MethodInvoker(()=> game.loop.window.MainMenu.Visible = true));
                    }
                  
                    game.loop.window.CreateGraphics().Clear(Color.White);
                   
                    game.loop.Running = false;
                    game.loop.loopThread.Abort();
                }


                //load(file); //herlaadt het spel
            }


            speler.update(keyboard, time);
            for (int i = 0; i < tiles.Length; i++)
            {
                for (int u = 0; u < tiles[i].Length; u++)
                {
                    if (tiles[i][u] != null)
                    {
                        tiles[i][u].Update();
                    }
                }
            }
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities.ToArray()[i] is Entity.Entity)
                {
                    Entity.Entity enitity = (Entity.Entity)entities.ToArray()[i];
                    enitity.update(time);
                }
            }
        }

    }
}
