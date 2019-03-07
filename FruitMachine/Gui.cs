using System;
using System.Runtime.InteropServices;

namespace FruitMachine
{
    public class Gui
    {
        private static string _firstLine;
        private static string _secondLine;
        private static string _thirdLine;
        private static string _fourthLine;


        internal void GenerateLines()
        {
            _firstLine = "";
            _secondLine = "";
            _thirdLine = "";
            _fourthLine = "";
            foreach (var variable in Game.Reels)
            {
                _firstLine += Ascii.GetFruit(variable.Index)[0];
                _secondLine += Ascii.GetFruit(variable.Index)[1];
                _thirdLine += Ascii.GetFruit(variable.Index)[2];
                _fourthLine += Ascii.GetFruit(variable.Index)[3];
            }
        }

        internal void renderFruits()
        {
            Console.WriteLine(_firstLine);
            Console.WriteLine(_secondLine);
            Console.WriteLine(_thirdLine);
            Console.WriteLine(_fourthLine);
        }
    }
}