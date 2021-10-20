using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class InspectTorchM : Main
    {
        public static void InspectTorch()
        {

            Console.Clear();
            string message1 = $@"
        

        You examine the unlit torch more closely noticing the jagged edges.
        Too dark to fully make everything out you accidentatily get a spliter.
        OUCH! As you pull it out, feeling a bit off, as if you have taken literal
        damage... ─── -1 HP
        ";
            Menu.AnimateTyping(message1, 25);
            BPrompt = message1;
            BOptions = new[] { "Inventory", "Search" };
            Menu goback = new Menu(BPrompt, new[] { "Back" });
            goback.Run(goback.SelectedIndex = 0);
            Warrior.Selection = 2;

        }
    }
}
