using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FruitMachine
{
    public class Game
    {
        public static List<Reel> Reels { get; } = new List<Reel>();
        private int _reelNumber = 3;
        private readonly Random _random = new Random();
        private bool _running = true;
        Gui gui = new Gui();

        internal int Credits = 200;
        internal int PlayerBet;

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

        internal void Render()
        {
            Console.Clear();
            string indexes = "";
            foreach (var reel in Reels)
            {
                indexes += reel.Index + " ";
            }
            Console.WriteLine(indexes);
            gui.GenerateLines(Credits, PlayerBet);
        }

        public void Run()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (_running)
            {
                if (Reels[Reels.Count -1].IsRunning && stopwatch.ElapsedMilliseconds > 30)
                {
                    Tick();
                    Render();
                    stopwatch.Restart();
                }
                else if (!Reels[Reels.Count - 1].IsRunning)
                {
                    _running = false;
                }
            }
            stopwatch.Stop();
        }

        public void Bet(int amount)
        {
            PlayerBet = amount;
            Credits = Credits - PlayerBet;
            Render();
        }
    }
}