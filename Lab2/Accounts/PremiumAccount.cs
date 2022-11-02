using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Base;

namespace Lab2.Accounts
{
    public class PremiumAccount : BaseAccount
    {
        public PremiumAccount(string name) : base(name)
        {

        }
        public override void WinGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            CurrentRating += game.Rating;
            GamesList.Add(game);
        }

        public override void LoseGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            CurrentRating -= game.Rating / 2;
            GamesList.Add(game);
        }
    }
}
