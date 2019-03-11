using System;

namespace FruitMachine
{
    public class HelpPage
    {
       
        public static void RenderHelpPage()
        {
        string helpText = @"

Welcome to this simple ASCII fruit machine!

The instructions are painfully simple:

1. Press b to place a bet. You can change it as many times as
  you like before starting!
2. Press s to start the machine.
3. Press q to quit the game.  

Press enter to continue...

        ";
            Console.Clear();
            Console.WriteLine(helpText);
            Console.ReadLine();
        }

    }
}