using Lab2.Accounts;
using Lab2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Games
{
    public class Game : BaseGame
    {
        public Game(BaseAccount player, BaseAccount opponent, DateTime date, int rating) 
            : base(player, opponent, date, rating)
        {

        }

        public override void PlayGame()
        {
            Player.WinGame(this, Opponent, Date);
            Opponent.LoseGame(this, Player, Date);
        }
    }
}
