using Lab2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Accounts;

namespace Lab2.Games
{
    public class SoloRatingGame : BaseGame
    {
        public SoloRatingGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating)
            : base(player, opponent, date, rating)
        {

        }
        public override void PlayGame()
        {
            Type = GameTypes.SoloRating.ToString();
            int temp = Rating;
            Player.WinGame(this, Opponent, Date);
            Rating = 0;
            Opponent.LoseGame(this, Player, Date);
            Rating = temp;
        }
    }
}
