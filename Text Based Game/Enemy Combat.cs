using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class EnemyCombat : Monsters
    {
        public static void Abilities(Slayers player, Monsters enemy)
        {
            Random random = new Random();
            int choice = random.Next(1);
            if (choice == 1)
            {
                if (enemy.Energy >= 20)
                {
                    Console.WriteLine(enemy.Name + " used Strong Attack! Did 20 damage, lost 20 energy.");
                    Combat.takeDamage(player, 20);
                    enemy.Energy -= 20;
                }
                else
                {
                    Console.WriteLine("Not enough energy to use move!");
                }
            }
            if (choice == 2)
            {
                if (enemy.Energy >= 15)
                {
                    Console.WriteLine(enemy.Name + " used Heal! Restored 25 health, lost 15 energy.");
                    enemy.Health += 25;
                    enemy.Energy -= 15;
                }
                else
                {
                    Console.WriteLine("Not enough energy to use move!");
                }
            }
            if (enemy.Health > 100)
            {
                enemy.Health = 100;
            }
        }

        public virtual void Attack(Slayers player, Monsters enemy)
        {
            Console.WriteLine(enemy.Name + " attacked! " + player.Name + " takes " + enemy.Strength + " damage.");
            takeDamage(player, enemy.Strength);
        }

        public static void Fight<T>(Slayers player, Monsters enemy) where T : EnemyCombat, new()
        {
            Console.Clear();
            Console.WriteLine(ASCII.FightPrompt(player, enemy));
            Random random = new Random();
            int rand = random.Next(1, 3);
            if (rand == 1)
            {
                T t = new T();
                t.Attack(player, enemy);
            }
            if (rand == 2)
            {
                Abilities(player, enemy);
            }
            if (rand == 3)
            {
                Items(player, enemy);
            }
        }

        public static void Items(Slayers player, Monsters enemy)
        {
            Random random = new Random();
            int rand = random.Next(1, 3);
            if (rand == 1)
            {
                if (enemy.Potions != 0)
                {
                    Console.WriteLine(enemy.Name + " used a potion! Restored 30 health.");
                    enemy.Health += 30;
                    enemy.Potions -= 1;
                }
                else
                {
                    Console.WriteLine("Enemy has no potions left.");
                }
            }
            if (rand == 2)
            {
                if (enemy.Elixers != 0)
                {
                    Console.WriteLine(enemy.Name + " used an elixer! Restored 30 energy.");
                    enemy.Energy += 30;
                    enemy.Elixers -= 1;
                }
                else
                {
                    Console.WriteLine("Enemy has no elixers left.");
                }
            }
            if (enemy.Health > 100)
            {
                enemy.Health = 100;
            }
            if (enemy.Energy > 100)
            {
                enemy.Energy = 100;
            }
        }
        public static void takeDamage(Slayers player, int d)
        {
            player.Health -= d;
            if (player.Health <= 0)
            {
                Console.WriteLine("\n" + player.Name + " is out of health! " + player.Name + " loses!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Environment.Exit(0);
            }

        }
        public static void takeDamage(Monsters enemy, int d)
        {
            enemy.Health -= d;
            if (enemy.Health <= 0)
            {
                Console.WriteLine("\n" + enemy.Name + " is out of health! " + enemy.Name + " loses!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

    }
}

