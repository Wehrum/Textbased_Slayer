using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class StandUpM : Main
    {
        public static void StandUp()
        {
            if (Torch_B == false)
            {
                Console.Clear();
                string message = @"


            You standup disreading the fact that you haven't attempted to search
            for something to help you. Perhaps searching first would be a better
            alternative.
                ";
                Menu.AnimateTyping(message, 25);
                BPrompt = message;
                BOptions = new[] { "Feel Around", "Stand Up" };
                Menu goback = new Menu(BPrompt, new[] { "Back" });
                goback.Run(goback.SelectedIndex = 0);
            }
            else if (Torch_B == true)
            {
                Console.Clear();
                string message1 = @"


            With your trusty unlit torch equipped, you stand up.
            ";
                Menu.AnimateTyping(message1, 25);
                BPrompt = message1;
                BOptions = new[] { "Inventory", "Search", "Inspect Torch" };
                Warrior.Selection = 1;
            }
        }

    }
}
