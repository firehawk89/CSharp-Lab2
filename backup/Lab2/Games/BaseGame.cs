using Lab2.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Games
{
    public abstract class BaseGame
    {
        public Accounts.BaseAccount Player { get; }
        public Accounts.BaseAccount Opponent { get; }
        public DateTime Date { get; }
        public int Rating { get; }
        public string Status { get; }
        public int ID { get; }

        private static int gameID = 31200;
        public enum StatusList
        {
            Victory,
            Defeat,
            Draw
        }

        public BaseGame(Accounts.BaseAccount Player, Accounts.BaseAccount Opponent, DateTime Date, int Rating, string Status)
        {
            this.Player = Player;
            this.Opponent = Opponent;
            this.Date = Date;
            this.Rating = Rating;
            this.Status = Status;
            ID = ++gameID;
        }

        public abstract void PlayGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating);

        public abstract int getRating();
    }
}
