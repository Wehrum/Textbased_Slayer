using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Media;

namespace Text_Based_Game
{
    public class Menu
    {
        private int _selectedIndex;
        private string[] Options;
        private string Prompt;
        static private ConsoleColor color;
        private static bool sound = true;
        public static ConsoleColor Color { get => color; set => color = value; }
        public static bool Sound { get => sound; set => sound = value; }


        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { _selectedIndex = value; }
        }


        public Menu()
        { }
        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            this._selectedIndex = SelectedIndex;
        }

        public static void AnimateTyping(string text, int delay = 25)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Write(text[i]);
                System.Threading.Thread.Sleep(delay);
                //skip the animation if enter is pressed
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Write(text.Substring(i + 1));
                        break;
                    }
                }
            }
        }
            private void DisplayOptions()
        {
            ForegroundColor = Color;
            WriteLine(Prompt);
            SelectedIndex = SelectedIndex;
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if (i == SelectedIndex)
                {
                    prefix = "♦";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = Color;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = Color;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix} << {currentOption} >>");

            }
            ResetColor();
        }

        public int Run(int SelectIndex)
        {
            var music = Properties.Resources.scrollup;
            var soundPlayer = new SoundPlayer(music);
            var music1 = Properties.Resources.scrolldown;
            var soundPlayer1 = new SoundPlayer(music1);
            var music2 = Properties.Resources.select;
            var soundPlayer2 = new SoundPlayer(music2);
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                SelectedIndex = SelectedIndex;
                Console.ForegroundColor = Color;
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                //Update SelectedIndex based on arrow keys.
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    if(sound == true)
                    {
                        soundPlayer.Play();
                    }
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    if (sound == true)
                    {
                        soundPlayer1.Play();
                    }
                    SelectedIndex++;
                }
                if (SelectedIndex == Options.Length)
                {
                    SelectedIndex = 0;
                }
            } while (keyPressed != ConsoleKey.Enter);
            if (sound == true)
            {
                soundPlayer2.Play();
            }
            soundPlayer.Dispose();
            return SelectedIndex;
        
        }
    }

}

