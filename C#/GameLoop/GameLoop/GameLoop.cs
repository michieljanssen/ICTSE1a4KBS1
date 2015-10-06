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
        private Game game;

        private const float DEFAULT_UPS = 60;

        private Thread t;
        private Boolean running = false;

        public Thread loopThread { get { return t; } }
        public Boolean Running { get { return running; } set { running = value; } }
        public static long NanoTime{ get { return (long)(Stopwatch.GetTimestamp() / (Stopwatch.Frequency / 1000000000.0)); }} 

        private Window window;

        private float targetUps;
        private Boolean fpsLock;
        private int maxFps;

        public GameLoop(Window window, int targetUps, Boolean fpsLock, int maxFps) {
            this.window = window;
            this.targetUps = targetUps;
            this.fpsLock = fpsLock;
            this.maxFps = maxFps;
            t = new Thread(init);
            t.Start();
        }

        private void init()
        {
            game = new Game();
            running = true;
            run();
        }
        private void run()
        {
            long lastTime = NanoTime;
            long timer = NanoTime / 1000000;
            double nsUps = 1000000000.0 / targetUps;
            double deltaUps = 0;
            double nsFps = 1000000000.0 / maxFps;
            double deltaFps = 0;
            int frames = 0;
            int ups = 0;
            while (running)
            {
                long now = NanoTime;
                deltaUps += (now - lastTime) / nsUps;
                deltaFps += (now - lastTime) / nsFps;
                while (deltaUps >= 1)
                {
                    update(DEFAULT_UPS / targetUps);
                    deltaUps--;
                    ups++;
                }
                if (!fpsLock)
                {
                    if (window.InvokeRequired)
                    {
                        frames++;
                        window.Invoke(new MethodInvoker(window.Refresh));
                    }
                } else {
                    if (deltaFps >= 1) {
                        if (window.InvokeRequired)
                        {
                            frames++;
                            window.Invoke(new MethodInvoker(window.Refresh));
                        }
                        deltaFps--;
                    }
                }
                if (NanoTime / 1000000 - timer > 1000)
                {
                    timer += 1000;
                    Console.WriteLine("Ups: " + ups + " Fps: " + frames);
                    ups = 0;

                    frames = 0;
                }
                lastTime = now;
            }
        }
        public void render(object sender, PaintEventArgs e) {
            game.render(sender, e);
        }
        public void update(float time) {
            game.update(time);
        }
    }
}
