using System;
using System.IO;
using System.Linq;

namespace FruitMachine
{
    public class Controls
    {
        private Game _game;
        
        public Controls(Game game)
        {
            _game = game;
        }

        public void GetInput()
        {
            char input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case 'b':
                    Console.WriteLine("Please select amount:");
                    int amount = 0;
                    if (!int.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.WriteLine("Invalid number. Press any key co continue...");
                        Console.ReadLine();
                        _game.Render();
                        GetInput();
                    }

                    if (amount > _game.Credits)
                    {
                        Console.WriteLine("Not enough credits! Press any key to continue...");
                        Console.ReadLine();
                        _game.Render();
                        GetInput();
                        
                    }
                    _game.Bet(amount);
                    GetInput();
                    break;
                case 's':
                    _game.Running = true;
                    _game.CreateReels();
                    _game.Run();
                    break;
                case 'h':
                    HelpPage.RenderHelpPage();
                    _game.Render();
                    GetInput();
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