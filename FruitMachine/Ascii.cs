using System;
using System.Net.NetworkInformation;

namespace FruitMachine
{
    public static class Ascii
    {
        public static string[] Apple = 
        {
            "|      |",
            "| ,(.  |",
            "|(   ) |",
            "| `\"'  |"
        };

        public static string[] Pear = 
        {
            "|  (   |",
            "| / \\  |",
            "|(   ) |",
            "| `\"'  |"
        };

        public static string[] Banana = 
        {
            "|      |",
            "|,     |",
            "|\\`.__.|",
            "| `._,'|"

        };

        public static string[] Peach = 
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

        public static string[] Instructions = 
        {
            "     Instructions: ",
            "     [b] Bet an amount!",
            "     [s] Start the machine!",
            "     [q] Exit!"
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