using System;

namespace TheCoreGame
{
    public static class Tools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColofulCW(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch (type)
            {
                case "TheCoreGame.Characters.Melee.Warrior":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "TheCoreGame.Characters.Spellcasters.Mage":
                    color = ConsoleColor.Cyan;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }
        }
    }
}
