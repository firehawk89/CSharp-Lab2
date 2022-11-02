using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Base;

namespace Lab2.Accounts
{
    public class PlatinumAccount : BaseAccount
    {
        private static int s_winCount = 0;
        public PlatinumAccount(string name) : base(name)
        {

        }
        public override void WinGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            s_winCount++;
            if (s_winCount == 3)
            {
                CurrentRating += game.Rating * 2;
                s_winCount = 0;
            }
            else
            {
                CurrentRating += game.Rating;
            }
            GamesList.Add(game);
        }

        public override void LoseGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            this.CurrentRating -= game.Rating / 2;
            this.GamesList.Add(game);
        }
    }
}
