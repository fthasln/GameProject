using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Fatih";
            gamer.LastName = "Aslan";
            gamer.Tckn = "12345678901";
            gamer.DogumTarihi = "01.01.1991";

            Games games = new Games();
            games.Id = 1;
            games.GameName = "Fifa2021";
            games.GameType = "Football Game";
            games.Stock = 20;
            games.Price = 5;

            Sales sales = new Sales();
            sales.Id = 1;
            sales.GameId = games.Id;
            sales.GameName = games.GameName;
            sales.GamePrice = games.Price;
            sales.GamerId = gamer.Id;
            sales.GamerFirstName = gamer.FirstName;
            sales.GamerLastName = gamer.LastName;

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer.Id,gamer.Tckn,gamer.FirstName,gamer.LastName,gamer.DogumTarihi);
            gamerManager.Update(gamer.Id, gamer.Tckn, gamer.FirstName, gamer.LastName, gamer.DogumTarihi);
            gamerManager.Delete(gamer.Id);
            gamerManager.CheckGamerInfoFromEDevlet(gamer.Id, gamer.Tckn, gamer.FirstName, gamer.LastName, gamer.DogumTarihi);

            GamesManager gamesManager = new GamesManager();
            gamesManager.Add(games.Id,games.GameName,games.GameType,games.Stock,games.Price);
            gamesManager.Update(games.Id, games.GameName, games.GameType, games.Stock, games.Price);
            gamesManager.Delete(games.Id, games.GameName, games.GameType, games.Stock, games.Price);

            SalesManager salesManager = new SalesManager();
            salesManager.sales(sales.Id,sales.GameId,sales.GameName,sales.GamePrice,sales.GamerId,sales.GamerFirstName,sales.GamerLastName);

        }
    }
}
