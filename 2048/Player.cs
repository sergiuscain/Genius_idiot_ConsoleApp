using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    internal class Player
    {
        internal string name;
        private int score;
        public int _score
        {
            get
            {
                return score;
            }
            set
            {
                if (value > 0) score = value;
            }
        }
        int mapSize;
        public Player(string name)
        {
            this.name = name;
            score = 0;
            mapSize = PlayForm.mapSize;
        }
    }
}
