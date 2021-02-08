using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager
    {
        public void sales(int Id, int GameId, string GameName, double GamePrice, int GamerId, string GamerFirstName, string GamerLastName)
        {
            Sales sales = new Sales();
            sales.Id = Id;
            sales.GameId = GameId;
            sales.GameName = GameName;
            sales.GamePrice = GamePrice;
            sales.GamerId = GamerId;
            sales.GamerFirstName = GamerFirstName;
            sales.GamerLastName = GamerLastName;

            Console.WriteLine(sales.GameName + " isimli oyun " + sales.GamerFirstName +" "+ sales.GamerLastName +" isimli oyuncu tarafından alınmıştır.");

        }
    }
}
