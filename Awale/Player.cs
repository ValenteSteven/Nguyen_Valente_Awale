using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale
{
    class Player
    {
        private int score;
        private String name;

        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }

        public Player(int score, string name)
        {
            this.score = score;
            this.name = name;
        }
    }
}
