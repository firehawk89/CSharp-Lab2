using Lab2.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Games
{
    public class TrainingGame : BaseGame
    {
        public TrainingGame(Accounts.BaseAccount Player, Accounts.BaseAccount Opponent, DateTime Date, int Rating, string Status)
            : base(Player, Opponent, Date, Rating, Status)
        {

        }
        public override void PlayGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating = 0)
        {
            player.WinGame(opponent, date, rating);
            opponent.LoseGame(player, date, rating);
        }

        public override int getRating()
        {
            return 0;
        }
    }
}
