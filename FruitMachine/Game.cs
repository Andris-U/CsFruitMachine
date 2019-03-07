using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FruitMachine
{
    public class Game
    {
        private List<Reel> reels = new List<Reel>();
        private int reelNumber = 3;
        readonly Random random = new Random();
        private bool running = true;

        public void CreateReels()
        {
            for (int i = 0; i < reelNumber; i++)
            {
                Reel reel = new Reel(200 + random.Next(80, 100) * i);
                reels.Add(reel);
            }
        }

        private void Tick()
        {
            foreach (Reel reel in reels)
            {
                if (reel.IsRunning)
                {
                    reel.Tick();
                }
            }
        }

        private void Render()
        {
            Console.Clear();
            String indexes = "";
            foreach (var reel in reels)
            {
                indexes += reel.Index + " ";
            }
            Console.WriteLine(indexes);
        }

        public void Run()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (running)
            {
                if (reels[reels.Count -1].IsRunning && stopwatch.ElapsedMilliseconds > 6)
                {
                    Render();
                    Tick();
                    stopwatch.Restart();
                }
                else if (!reels[reels.Count - 1].IsRunning)
                {
                    running = false;
                }
            }
            stopwatch.Stop();
        }
    }
}