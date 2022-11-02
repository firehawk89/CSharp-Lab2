using Lab2.Accounts;
using Lab2.Games;

BaseAccount firstPlayer = new Account("Anton");
BaseAccount secondPlayer = new PremiumAccount("Ivan");
BaseAccount thirdPlayer = new PlatinumAccount("Mykhailo");
var Games = new List<BaseGame> 
    (
    GameFactory.CreateGame(), 
    GameFactory.CreateTrainingGame(), 
    GameFactory.CreateSoloRatingGame()
    );

/*
firstPlayer.WinGame(secondPlayer, DateTime.Now, 5);
firstPlayer.LoseGame(secondPlayer, DateTime.Now, 15);
firstPlayer.LoseGame(secondPlayer, DateTime.Now, 7);
firstPlayer.WinGame(secondPlayer, DateTime.Now, 4);
firstPlayer.WinGame(secondPlayer, DateTime.Now, 1);
*/

Console.WriteLine(firstPlayer.GetStats());
Console.WriteLine(secondPlayer.GetStats());
Console.WriteLine($"{firstPlayer.UserName}'s Rating: " + firstPlayer.CurrentRating.ToString());
Console.WriteLine($"{secondPlayer.UserName}'s Rating: " + secondPlayer.CurrentRating.ToString());

