using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Games;

namespace Lab2.Accounts
{
    public class PlatinumAccount : BaseAccount
    {
        private static int winCount = 0;
        public PlatinumAccount(string name) : base(name)
        {

        }
        public override void WinGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            /*
            winCount++;
            if (winCount == 3)
            {
                this.CurrentRating += rating * 2;
                winCount = 0;
            }
            else
            {
                this.CurrentRating += rating;
            }
            var game = new Game(this, opponent, date, rating, BaseGame.StatusList.Victory.ToString());
            this.GamesList.Add(game);
            */
        }

        public override void LoseGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            /*
            this.CurrentRating -= rating / 2;
            var game = new Game(this, opponent, date, -(rating / 2), BaseGame.StatusList.Defeat.ToString());
            this.GamesList.Add(game);
            */
        }
    }
}
