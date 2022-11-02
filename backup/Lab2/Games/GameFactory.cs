using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Games
{
    public class GameFactory
    {
        public BaseGame CreateGame(Accounts.BaseAccount Player, Accounts.BaseAccount Opponent, DateTime Date, int Rating, string Status)
        {
            return new Game(Player, Opponent, Date, Rating, Status);
        }
        public BaseGame CreateTrainingGame(Accounts.BaseAccount Player, Accounts.BaseAccount Opponent, DateTime Date, int Rating, string Status)
        {
            return new TrainingGame(Player, Opponent, Date, Rating, Status);
        }

        public BaseGame CreateSoloRatingGame(Accounts.BaseAccount Player, Accounts.BaseAccount Opponent, DateTime Date, int Rating, string Status)
        {
            return new SoloRatingGame(Player, Opponent, Date, Rating, Status);
        }
    }
}
