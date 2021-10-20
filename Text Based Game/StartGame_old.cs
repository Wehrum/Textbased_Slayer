//using System;
//using System.Collections.Generic;
//using System.Media;
//using System.Text;
//using static System.Console;

//namespace Text_Based_Game
//{
//    class StartGame : Game
//    {
//        public static void Play()
//        {
//            Clear();
//            string prompt = @"
//                           ======================================
//                          |                                      |
//                          |     Welcome to Text Based Slayer!    |
//                          |                                      |
//                           ======================================           
//                                 Which slayer do you choose?";

//            string[] options = { "Enchanted Mage", "Brute Warrior", "Wity Archer" };
//            Menu mainMenu = new Menu(prompt, options);            
//            int indexValue = mainMenu.Run();

//        }
//        public string Hero(int indexValue)
//        {
//            if (indexValue == 0)
//            {
//                Mage enchantedMage = new Mage();
//                enchantedMage.Name  = "Enchanted Mage";
//                return enchantedMage.Name;
//            }
//            else if (indexValue == 1)
//            {
//                Warrior BruteWarrior = new Warrior();
//                BruteWarrior.Name = "Brute Warrior";
//                return BruteWarrior.Name;
//            }

//            else if (indexValue == 2)
//            {
//                Archer WityArcher = new Archer();
//                WityArcher.Name = "Wity Archer";
//                return WityArcher.Name;
//            }
//            else
//            {
//                return "You needed to choose a hero";
//            }
//        }
        
//    }
//}
