using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamesManager
    {
        public void Add(int Id,string GameName,string GameType,int Stock,double Price)
        {
            Games games = new Games();
            games.Id = Id;
            games.GameName = GameName;
            games.GameType = GameType;
            games.Stock = Stock;
            games.Price = Price;

            Console.WriteLine(GameName + " adlı oyun sisteme eklenmiştir.");
        }

        public void Update(int Id, string GameName, string GameType, int Stock, double Price)
        {
            Games games = new Games();
            games.Id = Id;
            games.GameName = GameName;
            games.GameType = GameType;
            games.Stock = Stock;
            games.Price = Price;

            Console.WriteLine(GameName + " adlı oyun bilgileri güncellenmiştir.");
        }

        public void Delete(int Id, string GameName, string GameType, int Stock, double Price)
        {
            Games games = new Games();
            games.Id = Id;
            games.GameName = GameName;
            games.GameType = GameType;
            games.Stock = Stock;
            games.Price = Price;

            Console.WriteLine(GameName + " adlı oyun sistemden silinmiştir.");
        }
    }
}
