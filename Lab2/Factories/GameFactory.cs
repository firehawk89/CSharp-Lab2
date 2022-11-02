using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Accounts;
using Lab2.Base;
using Lab2.Games;

namespace Lab2.Factories
{
    public class GameFactory
    {
        public BaseGame CreateGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating)
        {
            return new Game(player, opponent, date, rating);
        }
        public BaseGame CreateTrainingGame(BaseAccount player, BaseAccount opponent, DateTime date)
        {
            return new TrainingGame(player, opponent, date, 0);
        }

        public BaseGame CreateSoloRatingGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating)
        {
            return new SoloRatingGame(player, opponent, date, rating);
        }
    }
}
