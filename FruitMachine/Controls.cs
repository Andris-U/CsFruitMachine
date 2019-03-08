using System;

namespace FruitMachine
{
    public class Controls
    {
        private Game game;
        
        public Controls(Game game)
        {
            this.game = game;
        }

        public void GetInput()
        {
            char input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case 'b':
                    Console.WriteLine("Please select amount:");
                    int amount = int.Parse(Console.ReadLine());
                    game.Bet(amount);
                    GetInput();
                    break;
                case 's':
                    game.Run();
                    break;
                default:
                    GetInput();
                    break;
            }
        }
        
        
    }
}