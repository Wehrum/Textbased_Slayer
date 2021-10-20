using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class Combat : Slayers
    {

        public static void Abilities(Slayers player, Monsters enemy, ref bool mybool)
        {
            //bool is set to _ which is blank as the parameter doesn't NEED anything passed, it's only used to return a value of true or false.
            string[] options1 = { $"Use Strong Attack", $"Use Heal", "Go Back" };
            string prompt = ASCII.FightPrompt(player, enemy);
            Menu Items = new Menu(prompt, options1);
            bool endInnerLoop = false;
            EndLoop = false;
            {
                while (endInnerLoop == false)
                {
                    int selectedIndex1 = Items.Run(Items.SelectedIndex);
                    if (selectedIndex1 == 0)
                    {
                        if (player.Energy >= 20)
                        {
                            Monsters.Message = "";
                            Message = @"" + player.Name + " used Strong Attack! Did 20 damage, lost 20 energy.";
                            takeDamage(enemy, 20);
                            player.Energy -= 20;
                            endInnerLoop = true;
                            mybool = true;

                        }
                        else if (player.Energy < 20)
                        {
                            Console.WriteLine("Can't use this ability, your energy is below 20!");
                            System.Threading.Thread.Sleep(2000);
                        }

                    }
                    if (selectedIndex1 == 1)
                    {
                        if (player.Energy >= 15 && player.Health < 100)
                        {
                            Monsters.Message = "";
                            Message = player.Name + " used Heal! Restored 25 health, lost 15 energy.";
                            player.Health += 25;
                            player.Energy -= 15;
                            if (player.Health > 100)
                            {
                                int result = player.Health - 100;
                                Console.WriteLine($"{result} HP was wasted! Healing heals 25 HP!");
                                System.Threading.Thread.Sleep(3500);
                                player.Health = 100;
                                endInnerLoop = true;
                                mybool = true;

                            }
                        }
                        else if (player.Energy < 15)
                        {
                            Console.WriteLine("Can't use this ability, your energy is below 15!");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else if (player.Health >= 100)
                        {
                            Console.WriteLine($"You're already at {player.Health}HP which is your max health! ");
                            System.Threading.Thread.Sleep(2000);

                        }
                    }
                    if (selectedIndex1 == 2)
                    {
                        Console.Clear();
                        Items.SelectedIndex = 2;
                        endInnerLoop = true;
                    }
                }
            }

        }

        public virtual void Attack(Slayers player, Monsters enemy)
        {
            //Console.WriteLine("\n" + player.Name + " attacked! " + enemy.Name + " takes " + player.Strength + " damage.");
            takeDamage(enemy, player.Strength);
        }
        public static void Fight<T>(Slayers player, Monsters enemy) where T : Combat, new()
        {
            T t = new T();
            Console.Clear();
            string prompt = ASCII.FightPrompt(player, enemy);
            string[] options = { "Attack", "Abilites", "Items" };
            Menu mainMenu = new Menu(prompt, options);
            bool exitLoop = false;
            while (exitLoop == false)
            {
                int selectedIndex = mainMenu.Run(mainMenu.SelectedIndex);
                switch (selectedIndex)
                //IF adding new methods to the switch containing MENUS you MUST follow the same concept as "Abilites" and "Items" and return the EndLoop bool when needed.
                //If not, you won't be able to end the loop in this switch. Follow those examples to gain the understanding and when adding methods use the same logic of calling 
                //the method with an "if" statement seen below.
                //Methods that don't require a loop back can start with exitLoop = true and then call the method as in in Attack.
                {
                    case 0:
                        exitLoop = true;
                        t.Attack(player, enemy);
                        break;
                    case 1:
                        {
                            bool mybool = false;
                            Abilities(player, enemy, ref mybool);
                            if (mybool == true)
                            {
                            exitLoop = true;
                            }
                        }
                        break;
                    case 2:
                        {
                            Items(player, enemy);
                            if (EndLoop == true)
                            {
                                exitLoop = true;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Something went seriously wrong");
                        Console.ReadKey();
                        break; 

                }
            }

        }
        public static void Items(Slayers player, Monsters enemy)
        {
            //bool is set to _ which is blank as the parameter doesn't NEED anything passed, it's only used to return a value of true or false.
            string[] options1 = { $"Use Potions - [{player.Potions}]", $"Use Elixer - [{player.Elixers}]", "Go Back" };
            string prompt = ASCII.FightPrompt(player, enemy);
            Menu Items = new Menu(prompt, options1);
            bool endInnerLoop = false;
            EndLoop = false;
            while (endInnerLoop == false)
            {
                int selectedIndex1 = Items.Run(Items.SelectedIndex);
                if (selectedIndex1 == 0)
                {
                    if (player.Potions != 0 && player.Health < 100)
                    {
                        Monsters.Message = "";
                        Message = player.Name + " used a potion! Restored 30 health.";
                        player.Health += 30;
                        player.Potions -= 1;
                        if (player.Health > 100)
                        {
                            int result = player.Health - 100;
                            Console.WriteLine($"{result} HP was wasted! Potions heal 30 HP!");
                            System.Threading.Thread.Sleep(3500);
                            player.Health = 100;

                        }
                        endInnerLoop = true;
                        EndLoop = true;
                    }
                    else if (player.Health >= 100)
                    {
                        Console.WriteLine($"You're already at {player.Health}HP which is your max health! ");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("\n\nNo potions left!");
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                if (selectedIndex1 == 1)
                {
                    if (player.Elixers != 0 && player.Energy < 100)
                    {
                        Slime.Message = "";
                        Message = player.Name + " used an elixer! Restored 30 energy.";
                        player.Energy += 30;
                        player.Elixers -= 1;
                        if (player.Energy > 100)
                        {
                            int result = player.Energy - 100;
                            Console.WriteLine($"{result} Energy was wasted! Elixers heal 30 Energy!");
                            System.Threading.Thread.Sleep(3500);
                            player.Energy = 100;
                        }
                        endInnerLoop = true;
                        EndLoop = true;
                    }
                    else if (player.Energy >= 100)
                    {
                        Console.WriteLine($"You're already at {player.Energy} energy which is your max energy! ");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("\n\nNo elixers left");
                        System.Threading.Thread.Sleep(1000);
                    }

                }
                if (selectedIndex1 == 2)
                {
                    Console.Clear();
                    Items.SelectedIndex = 2;
                    endInnerLoop = true;
                }
            }
        }
        public static void takeDamage(Slayers player, int d)
        {
            player.Health -= d;
            if (player.Health <= 0)
            {
                Console.WriteLine("\n" + player.Name + " is out of health! " + player.Name + " loses!");
                Console.WriteLine("Press any key to continue...");
                System.Threading.Thread.Sleep(2500);
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
            }
        }
    }
}