using Lab2.Accounts;
using Lab2.Base;
using Lab2.Factories;

AccountFactory accountFactory = new AccountFactory();
GameFactory gameFactory = new GameFactory();

var firstPlayer = accountFactory.CreateAccount("Anton");
var secondPlayer = accountFactory.CreatePremiumAccount("Ivan");
var thirdPlayer = accountFactory.CreatePlatinumAccount("Mykhailo");

List<BaseAccount> accounts = new List<BaseAccount>();
accounts.Add(firstPlayer);
accounts.Add(secondPlayer);
accounts.Add(thirdPlayer);

/*
try
{
    gameFactory.CreateGame(firstPlayer, thirdPlayer, DateTime.Now, -3).PlayGame();
} catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine(e);
}
*/

gameFactory.CreateGame(thirdPlayer, secondPlayer, DateTime.Now, 2).PlayGame();
gameFactory.CreateGame(thirdPlayer, secondPlayer, DateTime.Now, 1).PlayGame();
gameFactory.CreateGame(thirdPlayer, firstPlayer, DateTime.Now, 4).PlayGame();
gameFactory.CreateGame(firstPlayer, thirdPlayer, DateTime.Now, 7).PlayGame();
gameFactory.CreateSoloRatingGame(firstPlayer, thirdPlayer, DateTime.Now, 12).PlayGame();
gameFactory.CreateSoloRatingGame(thirdPlayer, secondPlayer, DateTime.Now, 2).PlayGame();
gameFactory.CreateSoloRatingGame(firstPlayer, secondPlayer, DateTime.Now, 5).PlayGame();
gameFactory.CreateTrainingGame(firstPlayer, secondPlayer, DateTime.Now).PlayGame();
gameFactory.CreateTrainingGame(secondPlayer, thirdPlayer, DateTime.Now).PlayGame();
gameFactory.CreateTrainingGame(thirdPlayer, firstPlayer, DateTime.Now).PlayGame();

foreach (var account in accounts)
{
    Console.WriteLine(account.GetStats());
}