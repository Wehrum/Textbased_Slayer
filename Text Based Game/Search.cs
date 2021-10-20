using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class SearchM : Main
    {
        public static void Search()
        {
            if (Warrior.Selection == 2)
            {
                Console.Clear();
                string message1 = $@"


        You begin searching not really sure what you're looking for. 
        Other than something that might light this damned torch!
        You fumble around in the darkness and almost trip a few times
        You feel the rock around you, it's all rock...
        After a complete search of the entire area you've come to the 
        realization that you're in fact in some sort of cave system
            ";

                Menu.AnimateTyping(message1, 15);
                BPrompt = message1;
                Menu goback1 = new Menu(BPrompt, new[] { "Continue" });
                goback1.Run(goback1.SelectedIndex);
                Console.Clear();
                string message2 = $@"
        Testing Continue buttion does this work correctly?





        ";
                Menu.AnimateTyping(message2, 25);
                BPrompt = message2;
                BOptions = new[] { "END OF GAME FOR NOW" };
                Menu goback2 = new Menu(BPrompt, new[] { "No", "Yes" });
                goback2.Run(goback2.SelectedIndex);
                Console.Clear();
            }

            else if (Warrior.Selection == 1)
            {
                Console.Clear();
                string message = @"


        You begin searching not really sure what you're looking for. 
        Other than something that might light this damned torch!
        You fumble around in the darkness and almost trip a few times
        You feel the rock around you, it's all rock...
        After a complete search of the entire area you've come to the 
        realization that you're in fact in some sort of cave system
            ";

                Menu.AnimateTyping(message, 25);
            }
        }
    }
}
