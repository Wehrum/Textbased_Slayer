using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class BaseGame : Slayers
    {
        //default prompt/options for menu
        private static string _bprompt;
        private static string[] _boptions;
        private static string _ui;
        private static string _x = "";
        private static List<string> items = new List<string>();
        private static List<string> equip = new List<string>();
        private static List<string> consume = new List<string>();
        private static bool back;


        public static List<string> Items { get => items; set => items = value; }
        public static List<string> Equipables { get => equip; set => equip = value; }
        public static List<string> Consumables { get => consume; set => consume = value; }
        public static string BPrompt { get => _bprompt; set => _bprompt = value; }
        public static string[] BOptions { get => _boptions; set => _boptions = value; }
        public static string UI { get => _ui; set => _ui = value; }
        public static string X { get => _x; set => _x = value; }


        #region Inventory backing fields
        #region inventory bools
        // bools for inventory, EX: Does player have Torch (true or false)

        private static bool _torch_b;

        #endregion

        #region inventory strings
        // strings for inventory, EX: Torch = "Torch" allows seemless integration to inventory

        #endregion
        #endregion 

        #region Inventory encapulsations
        #region Inventory (bool)

        public static bool Torch_B { get => _torch_b; set => _torch_b = value; }
        public static bool Back { get => back; set => back = value; }

        #endregion

        #region Inventory (strings)
        #endregion
        #endregion

        #region Default constructor
        //Assigns default values for everything. EX: Values of things when the player first starts the game
        public BaseGame()
        {
            _x = X;
            _bprompt = BPrompt;
            _boptions = BOptions;
            Torch_B = false;
            Back = false;
            UI = $@"

        ───────────────────────────────────────────────
        HP: {Health}    Name: {Name}    Energy: {Energy}     
        ───────────────────────────────────────────────";
        }
        #endregion
        }
}