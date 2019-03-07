using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FruitMachine
{
    public class Game
    {
        public static List<Reel> Reels { get; } = new List<Reel>();
        private int _reelNumber = 3;
        readonly Random _random = new Random();
        private bool _running = true;
        Gui gui = new Gui();

        public void CreateReels()
        {
            for (int i = 0; i < _reelNumber; i++)
            {
                Reel reel = new Reel(150 + _random.Next(50, 70) * i);
                Reels.Add(reel);
            }
        }

        private void Tick()
        {
            foreach (Reel reel in Reels)
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
            string indexes = "";
            foreach (var reel in Reels)
            {
                indexes += reel.Index + " ";
            }
            Console.WriteLine(indexes);
            gui.GenerateLines();
            gui.renderFruits();
        }

        public void Run()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (_running)
            {
                if (Reels[Reels.Count -1].IsRunning && stopwatch.ElapsedMilliseconds > 30)
                {
                    Render();
                    Tick();
                    stopwatch.Restart();
                }
                else if (!Reels[Reels.Count - 1].IsRunning)
                {
                    _running = false;
                }
            }
            stopwatch.Stop();
        }
    }
}