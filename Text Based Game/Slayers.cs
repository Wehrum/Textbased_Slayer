using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class Slayers
    {
        #region Fields

        private static int _sel;
        private int _elx;
        private static int _eng;
        private int _hp;
        private string _name;
        private int _pots;
        private int _str;
        private static bool _endLoop;
        private static string _message;

        public static string Message { get => _message; set => _message = value; }

        public static bool EndLoop { get => _endLoop; set => _endLoop = value; }

        public static int Selection { get => _sel; set => _sel = value; }

        #endregion Fields

        #region Constructors

        public Slayers()
        {
            _hp = 100;
            _eng = 100;
            _str = 10;
            _pots = 5;
            _elx = 5;
            _message = Message;
            _endLoop = EndLoop;
            _sel = Selection;
        }

        #endregion Constructors

        #region Properties

        public int Elixers
        {
            get { return _elx; }
            set { _elx = value; }
        }

        public int Energy
        {
            get { return _eng; }
            set { _eng = value; }
        }

        public int Health
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Potions
        {
            get { return _pots; }
            set { _pots = value; }
        }

        public int Strength
        {
            get { return _str; }
            set { _str = value; }
        }

        





        #endregion Properties     
    }
    
}

