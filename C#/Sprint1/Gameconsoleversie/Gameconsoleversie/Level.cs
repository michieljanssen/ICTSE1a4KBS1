using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameconsoleversie
{
    class Level
    {
        Tegel[][] tegels;
        Speler speler;
        //constructor
        public Level(int breedte, int hoogte,int startx,int starty,int eindx,int eindy)
        {
            speler = new Speler(startx, starty);
            tegels = new Tegel[hoogte][];   //2 dimensionale array(Lengte*breedte) Hoogte wordt hier bepaald
            for (int i=0; i< hoogte;i++)
            {
                tegels[i] = new Tegel[breedte];//breedte bepalen
                for (int f = 0; f < breedte; f++)
                {
                    tegels[i][f] = new Tegel(); //Elke cel wordt aangemaakt.
                }
            }
            //Bovenmuur gemaakt
            foreach(Tegel muur in tegels[0])
            {
                muur.Type = 1;
            }
            //Ondermuur gemaakt
            foreach (Tegel mur in tegels[hoogte-1])
            {
                mur.Type = 1;
            }
            //Zijmuren gemaakt
            foreach(Tegel[] aa in tegels)
            {
                for (int r = 0; r < aa.Length; r++)
                {
                    if(r==0 || r == aa.Length - 1) {
                        aa[r].Type = 1;
                    }
                }
            }
            //startpunt
            tegels[starty][startx].Type = 2;
            //eindpunt
            tegels[eindy][eindx].Type = 3;
            
        }

        internal void moveuserright()
        {
            if (tegels[speler.Y][speler.X + 1].Type != 1)
            {
                speler.X++;
            }
        }

        internal void moveuserleft()
        {
            if (tegels[speler.Y][speler.X-1].Type != 1)
            {
                speler.X--;
            }
        }

        internal void moveuserup()
        {
            if (tegels[speler.Y - 1][speler.X].Type != 1)
            {
                speler.Y--;
            }
        }

        internal void moveuserdown()
        {
            if (tegels[speler.Y + 1][speler.X].Type != 1)
            {
                speler.Y++;
            }
        }
        public void drawlvl()   //"tekenen" van het level
        {
            // Eerst alle tegels tekenen
            //foreach(Tegel[] a in tegels)
            //{
            //    foreach(Tegel b in a)
            //    {
            //        Console.Write("[" + b.Type+ "]");
            //    }
            //    Console.Write("\n");
            //}

            for (int u = 0; u < tegels.Length; u++)
            {
                for (int a = 0; a < tegels[u].Length; a++)
                {
                    Console.Write("[");
                    if (u == speler.Y && a == speler.X)
                    {
                        Console.Write("9");
                    }
                    else
                    {
                        if (tegels[u][a].Type == 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(+tegels[u][a].Type);
                        }
                    }
                    Console.Write("]");
                }
                Console.Write("\n");

            }
        }
        public Speler User
        {
            get { return speler; }
        }
    }
}
