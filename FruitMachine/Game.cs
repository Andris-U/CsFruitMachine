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
        internal bool Running = true;
        Gui _gui = new Gui();
        Controls _controls;

        internal int Credits = 200;
        internal int PlayerBet;

        public Game()
        {
            _controls = new Controls(this);
        }

        public void CreateReels()
        {
            Reels.Clear();
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
            
            ////// DEBUG INDEX OUTPUT //////
            string indexes = "";
            foreach (var reel in Reels)
            {
                indexes += reel.Index + " ";
            }
            Console.WriteLine(indexes);
            ////////////////////////////////
            
            _gui.GenerateLines(Credits, PlayerBet);
        }

        public void Run()
        {
            Stopwatch stopwatch = new Stopwatch();
            Credits = Credits - PlayerBet;
            stopwatch.Start();
            while (Running)
            {
                // Set FPS to 25 (1000ms / 25 = 40)
                if (Reels[Reels.Count -1].IsRunning && stopwatch.ElapsedMilliseconds > 40)
                {
                    Tick();
                    Render();
                    stopwatch.Restart();
                }
                else if (!Reels[Reels.Count - 1].IsRunning)
                {
                    Running = false;
                }
            }
            stopwatch.Stop();
            CheckResults();
            _controls.GetInput();
            
        }

        public void Bet(int amount)
        {
            PlayerBet = amount;
            Render();
        }

        public void CheckResults()
        {
            int winnings = 0;
            if (Reels[0].Index == Reels[1].Index && Reels[1].Index == Reels[2].Index)
            {
                if (Reels[0].Index == 0)
                {
                    winnings = PlayerBet * (int) Value.Apple;
                }
                else if (Reels[0].Index == 1)
                {
                    winnings = PlayerBet * (int) Value.Pear;
                }
                else if (Reels[0].Index == 2)
                {
                    winnings = PlayerBet * (int) Value.Banana;
                }
                else if (Reels[0].Index == 3)
                {
                    winnings = PlayerBet * (int) Value.Peach;
                }
                Credits += winnings;
                Render();
                _gui.RenderResults(Reels[0].Index, winnings);   
            }
            else
            {
                _gui.RenderResults(4, 0);
            }
        }
    }
}