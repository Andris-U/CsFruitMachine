using System;

namespace FruitMachine
{
    public class Controls
    {
        private Game _game;
        
        public Controls(Game game)
        {
            this._game = game;
        }

        public void GetInput()
        {
            char input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case 'b':
                    Console.WriteLine("Please select amount:");
                    int amount = int.Parse(Console.ReadLine());
                    _game.Bet(amount);
                    GetInput();
                    break;
                case 's':
                    _game.Running = true;
                    _game.CreateReels();
                    _game.Run();
                    break;
                case 'q':
                    Environment.Exit(0);
                    break;
                default:
                    GetInput();
                    break;
            }
        }
        
        
    }
}