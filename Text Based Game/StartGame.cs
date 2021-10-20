using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using static System.Console;

namespace Text_Based_Game
{
    class StartGame : Main
    {
        public static void Play()
        {
            Clear();
            string prompt = ASCII.TBSTitle() + @"   
______________________________
|                             |
| Put a tip here            ? |
|_____________________________|
";

            string[] options = { "New Game", "Load Game", "Go Back" };
            Menu mainMenu = new Menu(prompt, options);
            int indexValue = mainMenu.Run(0);

            switch(indexValue)
            {
                case 0:
                    Clear();
                    WarriorStart();
                    break;
                case 1:
                    Clear();
                    Console.WriteLine("Not added in yet");
                    break;
                case 2:
                    Clear();
                    MenuBase.RunMainMenu();
                    break;

            }
        }

    }

}
