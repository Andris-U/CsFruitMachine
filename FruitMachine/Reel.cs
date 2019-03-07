using System;

namespace FruitMachine
{
    public class Reel
    {
        static Random _random = new Random();
        private int _maxTime;
        public int Index { get; private set; } = _random.Next(0, 3); 
        private int _timer;
        public bool IsRunning { get; private set; } = true;

        public Reel(int maxTime)
        {
            this._maxTime = maxTime;
        }

        public void Tick()
        {
            if (_timer < _maxTime)
            {
                Index = Index == 4 ? 0 : Index += 1;
                _timer++;
            }
            else
            {
                IsRunning = false;
            }
        }
    }
}