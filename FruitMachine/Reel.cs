using System;

namespace FruitMachine
{
    public class Reel
    {
        static Random random = new Random();
        private int maxTime;
        public int Index { get; private set; } = random.Next(0, 3); 
        private int timer;
        public bool IsRunning { get; private set; } = true;

        public Reel(int maxTime)
        {
            this.maxTime = maxTime;
        }

        public void Tick()
        {
            if (timer < maxTime)
            {
                Index = Index == 4 ? 0 : Index += 1;
                timer++;
            }
            else
            {
                IsRunning = false;
            }
        }
    }
}