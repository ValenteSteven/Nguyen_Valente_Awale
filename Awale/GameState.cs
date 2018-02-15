using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale
{
    class GameState
    {
        private Player player1;
        private Player player2;
        private Boolean turnOfPlayer1;

        internal Player Player1 { get => player1; set => player1 = value; }
        internal Player Player2 { get => player2; set => player2 = value; }
        public bool TurnOfPlayer1 { get => turnOfPlayer1; set => turnOfPlayer1 = value; }

        public GameState(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void IncreasePlayerScore(int newScore)
        {
            if (TurnOfPlayer1)
            {
                this.player1.Score = this.player1.Score + newScore;
            }
            else
            {
                this.player2.Score = this.player2.Score + newScore;
            }
        }

        public void DecreasePlayerScore(int newScore)
        {
            if (TurnOfPlayer1)
            {
                this.player1.Score = this.player1.Score - newScore;
            }
            else
            {
                this.player2.Score = this.player2.Score - newScore;
            }
        }

        public void NextTurn()
        {
            Boolean b = this.TurnOfPlayer1;
            this.TurnOfPlayer1 = !b;
        }
    }
}
