using System;
using System.Net.NetworkInformation;

namespace FruitMachine
{
    public class Ascii
    {
        public static string[] Apple = new[]
        {
            "|      |",
            "| ,(.  |",
            "|(   ) |",
            "| `\"'  |"
        };

        public static string[] Pear = new[]
        {
            "|  (   |",
            "| / \\  |",
            "|(   ) |",
            "| `\"'  |"
        };

        public static string[] Banana = new[]
        {
            "|      |",
            "|,     |",
            "|\\`.__.|",
            "| `._,'|"

        };

        public static string[] Peach = new[]
        {
            "|      |",
            "| ,:.  |",
            "|(:::) |",
            "| `-'  |"
        };

        public static string[] GetFruit(int index)
        {
            switch (index)
            {
                case 0:
                    return Apple;
                case 1:
                    return Pear;
                case 2:
                    return Banana;
                case 3:
                    return Peach;
                default:
                    return Apple;
            } 
        }
    }
}