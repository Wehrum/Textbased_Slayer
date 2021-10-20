using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using static System.Console;
using System.Threading;

namespace Text_Based_Game
{
    class MenuBase : Menu
    {
        public static void Start()
        {
            Console.Title = "Text Based Slayer";
            RunMainMenu();
        }
        public static void RunMainMenu()
        {
            string prompt = ASCII.TBSTitle();
            string[] options = { "Play", "Options", "About", "Developer Menu", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run(mainMenu.SelectedIndex = 0);


            switch (selectedIndex)
            {
                case 0:
                    StartGame.Play();
                    break;
                case 1:
                    Options();
                    break;
                case 2:
                    About();
                    break;
                case 3:
                    Developer();
                    break;
                case 4:
                    Environment.Exit(1);
                    break;
                default:
                    Default();
                    break;

            }

        }

        private static void About()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"
                             __| |____________________________________________| |__
                             (__   ____________________________________________   __)
                               | |                                            | |
                               | |                Made By:                    | |
                               | |              Marquis Marshall              | |
                               | |                 And                        | |
                               | |              Connor Wehrum                 | |
                               | |                                            | |
                             __| |____________________________________________| |__
                            (__   ____________________________________________   __)
                               | |                                            | |
");
            Console.ReadKey();
            RunMainMenu();

        }
        private static void Options()
        {
            string prompt = ASCII.OptionsTitle();

            string[] options = { "Change Color" ,"Toggle Menu Sounds", "Go back" };
            Menu mainMenu = new Menu(prompt, options);
            bool exitLoop = false;
            while (exitLoop == false)
            {
                int selectedIndex = mainMenu.Run(0);
                switch (selectedIndex)
                {
                    case 0:
                        ChangeColor();
                        break;
                    case 1:
                        if (Menu.Sound == true)
                        {
                            Menu.Sound = false;
                        }
                        else
                        {
                            var music2 = Properties.Resources.select;
                            var soundPlayer2 = new SoundPlayer(music2);
                            soundPlayer2.Play();
                            Menu.Sound = true;
                        }
                        break;
                    case 2:
                        exitLoop = true;
                        RunMainMenu();
                        break;
                }




            }
        }
        private static void ChangeColor()
        {
            string prompt = ASCII.OptionsTitle();

            string[] options = { "Red", "Green", "Blue", "Yellow", "Purple", "White", "Gray", "Go back" };
            Menu mainMenu = new Menu(prompt, options);
            bool exitLoop = false;
            while (exitLoop == false)
            {
                int selectedIndex = mainMenu.Run(0);
                switch (selectedIndex)
                {
                    case 0:
                        Menu.Color = ConsoleColor.Red;
                        break;
                    case 1:
                        Menu.Color = ConsoleColor.Green;
                        break;
                    case 2:
                        Menu.Color = ConsoleColor.Blue;
                        break;
                    case 3:
                        Menu.Color = ConsoleColor.Yellow;
                        break;
                    case 4:
                        Menu.Color = ConsoleColor.Magenta;
                        break;
                    case 5:
                        Menu.Color = ConsoleColor.White;
                        break;
                    case 6:
                        Menu.Color = ConsoleColor.Gray;
                        break;
                    case 7:
                        exitLoop = true;
                        Options();
                        break;
                }
            }
        }
        private static void Default()
        {
            string prompt = ASCII.TBSTitle();
            string[] options = { "This game is currently in pre-pre-pre alpha and that has not been implemented." };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run(mainMenu.SelectedIndex = 0);
            switch (selectedIndex)
            {
                case 0:
                    RunMainMenu();
                    break;
            }
        }

        public static void Developer()
        {
            string prompt = ASCII.DevTitle();

            string[] options = { "Play flora.wav", "Force Fight Slime", "Go back" };
            Menu mainMenu = new Menu(prompt, options);
            bool exitLoop = false;
            while (exitLoop == false)
            {
                int selectedIndex = mainMenu.Run(0);
                switch (selectedIndex)
                {
                    case 0:
                        //Game.Music();
                        mainMenu.SelectedIndex = 0;
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Who would you like to fight the Slime Boss as?");
                        Console.WriteLine();
                        Console.WriteLine("A. Mage");
                        Console.WriteLine("B. Warrior");
                        Console.WriteLine("C. Archer");
                        Console.WriteLine("");
                        Console.WriteLine("Press any OTHER key to go back");
                        ConsoleKey keypressed;
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keypressed = keyInfo.Key;
                        if (keypressed == ConsoleKey.A)
                        {
                            Console.Clear();
                            //Console.ForegroundColor = ConsoleColor.Green;
                            //Console.WriteLine(ASCII.SlimeAppear());
                            //Thread.Sleep(3500);
                            //Console.Clear();
                            //Console.WriteLine(@"




                            //                        ______                                _           __ _       _     _   _ 
                            //                        | ___ \                              | |         / _(_)     | |   | | | |
                            //                        | |_/ / __ ___ _ __   __ _ _ __ ___  | |_ ___   | |_ _  __ _| |__ | |_| |
                            //                        |  __/ '__/ _ \ '_ \ / _` | '__/ _ \ | __/ _ \  |  _| |/ _` | '_ \| __| |
                            //                        | |  | | |  __/ |_) | (_| | | |  __/ | || (_) | | | | | (_| | | | | |_|_|
                            //                        \_|  |_|  \___| .__/ \__,_|_|  \___|  \__\___/  |_| |_|\__, |_| |_|\__(_)
                            //                                      | |                                       __/ |            
                            //                                      |_|                                      |___/             





                            //");
                            //Thread.Sleep(3500);
                            Warrior myWarrior = new Warrior();
                            Slime mySlime = new Slime();
                            mySlime.Name = "Slime";
                            myWarrior.Name = "Mage";
                            myWarrior.Potions = 5;
                            while (myWarrior.Health >= 0 || mySlime.Health >= 0)
                            {
                                Combat.Fight<Warrior>(myWarrior, mySlime);
                                EnemyCombat.Fight<Slime>(myWarrior, mySlime);
                                Thread.Sleep(2500);
                                System.Console.Clear();
                            } 
                        }
                        else
                        {
                            
                        }
                            break;
                    case 2:
                        exitLoop = true;
                        RunMainMenu();
                        break;
                }


            }

        }

    }
}
