using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Games;

namespace Lab2.Accounts
{
    public class Account : BaseAccount
    {
        public Account(string name) : base(name)
        {

        }
        public override void WinGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            game.PlayGame(this, opponent, date, game.getRating());
        }
        public override void LoseGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            
        }
        public override void PlayGame(BaseAccount opponent, DateTime date, int rating)
        {

        }
    }
}
