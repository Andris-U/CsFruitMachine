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

        public static string Title =
            @"$$$$$$$$\               $$\  $$\           $$\      $$\                  $$\      $$\                   
$$  _____|              \__| $$ |          $$$\    $$$ |                 $$ |     \__|                  
$$ |   $$$$$$\ $$\   $$\$$\$$$$$$\         $$$$\  $$$$ |$$$$$$\  $$$$$$$\$$$$$$$\ $$\$$$$$$$\  $$$$$$\  
$$$$$\$$  __$$\$$ |  $$ $$ \_$$  _|        $$\$$\$$ $$ |\____$$\$$  _____$$  __$$\$$ $$  __$$\$$  __$$\ 
$$  __$$ |  \__$$ |  $$ $$ | $$ |          $$ \$$$  $$ |$$$$$$$ $$ /     $$ |  $$ $$ $$ |  $$ $$$$$$$$ |
$$ |  $$ |     $$ |  $$ $$ | $$ |$$\       $$ |\$  /$$ $$  __$$ $$ |     $$ |  $$ $$ $$ |  $$ $$   ____|
$$ |  $$ |     \$$$$$$  $$ | \$$$$  |      $$ | \_/ $$ \$$$$$$$ \$$$$$$$\$$ |  $$ $$ $$ |  $$ \$$$$$$$\ 
\__|  \__|      \______/\__|  \____/       \__|     \__|\_______|\_______\__|  \__\__\__|  \__|\_______|



";

        public static string[] Instructions = new[]
        {
            "     Please select an option: ",
            "     [b] Bet an amount,",
            "     [s] Start the machine!",
            "     [q] To exit!"
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