using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace FruitMachine
{
    public class Gui
    {

        internal void GenerateLines(int credits, int bet)
        {
            RenderTitle();
            RenderFruits();
            RenderStats(credits, bet);
        }

        internal void RenderTitle()
        {
            Console.WriteLine(Ascii.Title);
        }

        internal void RenderStats(int credits, int bet)
        {
            string stats = "";
            stats += "       Your credits: " + credits;
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
            thirdLine += Ascii.Instructions[2];
            fourthLine += Ascii.Instructions[3];
                        
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(thirdLine);
            Console.WriteLine(fourthLine);
        }

        internal void RenderResults(int index, int winnings)
        {
            string text;
            switch (index)
            {
                case 0:
                    text = "Three apples! You win: " + winnings;
                    break;
                case 1:
                    text = "Three pears! You win: " + winnings;
                    break;
                case 2:
                    text = "Three bananas! You win: " + winnings;
                    break;
                case 3:
                    text = "Three peaches! You win: " + winnings;
                    break;
                default:
                    text = "No luck! Try again!";
                    break;
                            
            }
            Console.WriteLine(text);
            Console.WriteLine("Please select an option...");
        }
    }
}