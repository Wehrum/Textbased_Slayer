using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class Main : Inventory
    {
        public static void WarriorStart()
        {
            Warrior myWarrior = new Warrior();
            Warrior.Selection = 0;

            string programmingQuote = @"Loading.......";
            Menu.AnimateTyping(programmingQuote, 200);
            System.Console.Clear();

            string programmingQuote1 = @"


            You awake and the first thing you hear is the faint sound of dripping water in an enclosed space.
            Slowly you open your eyes, noticing your vision is slightly blurry before coming into focus.
            It is extremely dark. So dark in fact, you can barely make out your hand that is three feet from your 
            face. To make matters worse you seem to be sprawled on the floor and bleeding from your head.
            At this point you realize you have no idea where you are.

            And are having a hard time remembering your name..
            ";
            Menu.AnimateTyping(programmingQuote1, 25);
            myWarrior.Name = Console.ReadLine();
            Console.Clear();
            string programmingQuote2 = $@"


            That's right, your name is {myWarrior.Name}. You should probably figure out where you are.. 
            Maybe try feeling around, perhaps you'll come across something.
            ";
            Menu.AnimateTyping(programmingQuote2, 25);

            //First default set of Warrior options and prompts
            BPrompt = programmingQuote2;
            BOptions = new[] { "Feel Around", "Stand up" };
            MainSwitch(myWarrior);
        }

        private static void MainSwitch(Slayers player)
        {
            while (true)
            {
                Menu mainMenu = new Menu(UI + BPrompt, BOptions);
                int selectedIndex = mainMenu.Run(mainMenu.SelectedIndex);
                if (selectedIndex == 0)
                {
                    if (Torch_B == true)
                    {
                        GameInventory(player);
                    }
                    else if (Torch_B == false)
                    {
                        FeelAroundM.FeelAround();
                    }

                }
                if (selectedIndex == 1)
                {
                    if (Warrior.Selection == 0)
                    {
                        StandUpM.StandUp();
                    }
                    else if (Torch_B == true && Warrior.Selection == 1 || Warrior.Selection == 2)
                    {
                        SearchM.Search();
                    }
                }
                if (selectedIndex == 2)
                {
                    if (Warrior.Selection == 1)
                    {
                        InspectTorchM.InspectTorch();
                    }
                }
            }
        }

        public static string InventorySwitch(string result)
        {
            //Switch for inventory equip/consumables
            //Whatever they press returns a string and will be used here ex: if they press torch it finds the case for torch and does whatever
            switch(result)
            {
                case "Torch":
                    return "";
                case "Back":
                    Console.WriteLine("You pressed back button");
                    Console.ReadKey();
                    //Loop back set to true to get them out of either equipables or consumables menu
                    Back = true;
                    return "";
                case "Egg":
                    Console.WriteLine("You pressed Egg");
                    Console.ReadKey();
                    return "";
                default:
                    Console.WriteLine("Test");
                    Console.ReadKey();
                    return "";
            }
        }
    }
    
}
