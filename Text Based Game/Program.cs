using Colorful;
using System;
using System.Media;
using static System.Console;
using System.Threading;
using System.Runtime.InteropServices;


namespace Text_Based_Game
{
    class Program
    {
        #region Console Window Options
        //Used to disabled certain aspects of the Console App at developers choice.
        //Used to disable "maxamizing" and "re-sizing" a window to prevent users from getting graphic glitches
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;


        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        static void Main(string[] args)
        {
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), true), SC_CLOSE, MF_BYCOMMAND);
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), true), SC_MINIMIZE, MF_BYCOMMAND);
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_MAXIMIZE, MF_BYCOMMAND);
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_SIZE, MF_BYCOMMAND);
            #endregion
            Menu.Color = ConsoleColor.Red;
            //Warrior myWarrior = new Warrior();
            //Inventory.GameInventory(myWarrior);
            MenuBase.Start();
        }
    }
}


