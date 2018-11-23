using System;
using System.Collections.Generic;
using TheCoreGame.Characters;
using TheCoreGame.Characters.Melees;
using TheCoreGame.Characters.Spellcasters;

namespace TheCoreGame
{
    class Program
    {
        static void Main()
        {
            Random rng = new Random();

            Melee currentMelee;
            Spellcaster currentSpellcaster;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                new Mage(),
                new Mage(),
                new Mage()
                //new Assassin(),
                //new Knight(),
                //new Druid(),
                //new Necromancer()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellcasterTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellcasterTeam.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentSpellcaster = spellcasterTeam[rng.Next(0, spellcasterTeam.Count)];

                
                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());

                if (!currentSpellcaster.IsAlive)
                {
                    currentMelee.WonBattle();
                    spellcasterTeam.Remove(currentSpellcaster);

                    if (spellcasterTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("\nMelee team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentSpellcaster = spellcasterTeam[rng.Next(0, spellcasterTeam.Count)];
                    }
                }

                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());

                if (!currentMelee.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("\nSpellcaster team wins!", ConsoleColor.Blue);
                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }
                }
            }
        }
    }
}
