using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    internal class Player
    {
        string name;
        int score;
        int mapSize;
        public Player(string name)
        {
            this.name = name;
            score = 0;

        }
    }
}
