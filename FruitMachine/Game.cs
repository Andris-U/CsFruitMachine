using System;
using System.Diagnostics;

namespace FruitMachine
{
    public class Game
    {
        private bool running = true;

        public void Tick()
        {
            
        }

        public void Run()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int counter = 0;
            while (running)
            {
                if (stopwatch.ElapsedMilliseconds > 6)
                {
                    Tick();
                    stopwatch.Restart();
                    Console.WriteLine("Testing" + counter);
                    counter++;
                }       
            }
            stopwatch.Stop();
        }
    }
}