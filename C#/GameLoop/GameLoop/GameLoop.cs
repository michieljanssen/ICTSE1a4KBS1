using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace GameLoop
{
    class GameLoop
    {
        //game class waar alles word geupdate en gerendert voor het spel
        public Game game;

        //constante voor de standaard update snelheid 
        //ups = updates per seconde
        private const float DEFAULT_UPS = 60;
        

        //thread voor het updaten en renderen van het spel
        private Thread t;
        private Boolean running = false;
        public Thread loopThread { get { return t; } }
        public Boolean Running { get { return running; } set { running = value; } }

        //krijgt tijd in nanoseconden
        public static long NanoTime{ get { return (long)(Stopwatch.GetTimestamp() / (Stopwatch.Frequency / 1000000000.0)); }} 

        //scherm
        private Window window;

        //gameloop variablen
        private float targetUps;
        private Boolean fpsLock;
        private int maxFps;

        //constructor
        public GameLoop(Window window, int targetUps, Boolean fpsLock, int maxFps) {
            //stelt alle variablen in
            this.window = window;
            this.targetUps = targetUps;
            this.fpsLock = fpsLock;
            this.maxFps = maxFps;
            //intalizeerd het spel
            game = new Game();
            //initalizeerd de gameloop thraed en start hem op de methode init();
            t = new Thread(init);
            t.Priority = ThreadPriority.Highest;
            t.TrySetApartmentState(ApartmentState.MTA);
            t.Start();
        }

        //initializatie
        private void init()
        {          
            running = true;
            run();
        }

        //de gameloop zelf
        private void run()
        {
            //variablen voor gameloop

            //stelt laaste tijd een cycle is gebeurt(1 cycle is een keer door de hele gameloop)
            long lastTime = NanoTime;

            //timer is de huidige tijd in milliseconden
            long timer = NanoTime / 1000000;

            //nsups is de doel tijd tussen updates
            double nsUps = 1000000000.0 / targetUps;
            //deltaups is waar gemeten word of het tijd is om te updaten
            double deltaUps = 0;
            //nsfps is de doel tijd tussen frames
            double nsFps = 1000000000.0 / maxFps;
            //deltafps is waar gemeten word of het tijd is om te renderen
            double deltaFps = 0;
            
            //staat voor de frames die voorbij zijn gegaan
            int frames = 0;
            //stat voor de updates die voorbij zijn gegaan
            int ups = 0;
            while (running)
            {
                //update maxfps en targetups om dynanmisch deze te kunnen veranderen 
                nsUps = 1000000000.0 / targetUps;
                nsFps = 1000000000.0 / maxFps;
                //tijd nu in nanonseconden
                long now = NanoTime;
                //berekent de delta voor updates
                deltaUps += (now - lastTime) / nsUps;
                //berekent de delta voor frames
                deltaFps += (now - lastTime) / nsFps;

                //als de delta voor ups groter is dan 1 dan voert hij een update uit todat de delta kleiner is dan 1
                while (deltaUps >= 1)
                {   
                    //update uitvoeren met een "time" parameter
                    //time parameter zorgt voor constante beweging/snelheid in het spel
                    update(DEFAULT_UPS / targetUps);
                    deltaUps--;
                    ups++;
                }
                //checked of er een fpslock/fpsmax is ingesteld
                if (!fpsLock)
                {
                    //checked of een invoke op de andere thread nodig is
                    if (window.InvokeRequired)
                    {
                        //voert het render event uit met een invoke
                        window.Invoke(new MethodInvoker(window.Refresh));
                    }
                    else { 
                        //voer het render event uit
                        window.Refresh();
                    }
                    frames++;
                } else {
                    //checked of er gerendered moet worden / dit is als de deltaFps groter dan 1 is
                    if (deltaFps >= 1) {
                        //checked of een invoke op de andere thread nodig is
                        if (window.InvokeRequired)
                        {
                            //voert het render event uit met een invoke
                            window.Invoke(new MethodInvoker(window.Refresh));
                        }
                        else
                        {
                            //voer het render event uit
                            window.Refresh();
                        }
                        frames++;
                        deltaFps--;
                    }
                }

                //checked of er een secoden voor bij is gegaan
                if (NanoTime / 1000000 - timer > 1000)
                {
                    //schrijft de UPS en FPS in de console
                    timer += 1000;
                    Console.WriteLine("Ups: " + ups + " Fps: " + frames);
                    //reset ups en frames variabelen
                    ups = 0;
                    frames = 0;
                }
                lastTime = now;
            }
        }

        //render event
        public void render(object sender, PaintEventArgs e) {
            //renders het spel
            game.render(sender, e);
        }

        //update methode
        public void update(float time) {
            //updates het spel
            game.update(time);
        }
    }
}
