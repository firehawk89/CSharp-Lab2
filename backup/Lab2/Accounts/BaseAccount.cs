using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Games;

namespace Lab2.Accounts
{
    public abstract class BaseAccount
    {
        public string UserName { get; set; }
        public int CurrentRating { get; set; }

        public int StartRating = 10;

        public List<BaseGame> GamesList = new List<BaseGame>();

        public BaseAccount(string name)
        {
            UserName = name;
            CurrentRating = StartRating;
        }

        public abstract void WinGame(BaseGame game, BaseAccount opponent, DateTime date);
        public abstract void LoseGame(BaseGame game, BaseAccount opponent, DateTime date);
        public abstract void PlayGame(BaseAccount opponent, DateTime date, int rating);
        public string GetStats()
        {
            var statistics = new StringBuilder();

            statistics.AppendLine($"{this.UserName}'s Stats:");
            statistics.AppendLine("Date\t\tPlayer\tOpponent\tStatus\t\tRating\tGame ID");

            foreach (var item in this.GamesList)
            {
                statistics.AppendLine($"{item.Date.ToShortDateString()}\t{item.Player.UserName}\t{item.Opponent.UserName}\t\t{item.Status}\t\t{item.Rating.ToString("+#;-#;0")}\t{item.ID}");
            }

            statistics.AppendLine($"Total Games Played: {this.GamesList.Count}");

            return statistics.ToString();
        }
    }
}
