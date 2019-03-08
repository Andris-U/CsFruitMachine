using System;
using System.Runtime.InteropServices;

namespace FruitMachine
{
    public class Gui
    {

        internal void GenerateLines(int credits, int bet)
        {
            renderTitle();
            RenderFruits();
            RenderStats(credits, bet);
        }

        internal void renderTitle()
        {
            Console.WriteLine(Ascii.Title);
        }

        internal void RenderStats(int credits, int bet)
        {
            string stats = "";
            stats += "        Your credits: " + credits;
            stats += "    Your bet: " + bet;
            Console.WriteLine();
            Console.WriteLine(stats);
            Console.WriteLine();
        }

        internal void RenderFruits()
        {
            string firstLine = "";
            string secondLine = "";
            string thirdLine = "";
            string fourthLine = "";
            
            foreach (var variable in Game.Reels)
            {
                firstLine += "      " + Ascii.GetFruit(variable.Index)[0];
                secondLine += "      " + Ascii.GetFruit(variable.Index)[1];
                thirdLine += "      " + Ascii.GetFruit(variable.Index)[2];
                fourthLine += "      " + Ascii.GetFruit(variable.Index)[3];
            }

            firstLine += Ascii.Instructions[0];
            secondLine += Ascii.Instructions[1];
            
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(thirdLine);
            Console.WriteLine(fourthLine);
        }
    }
}