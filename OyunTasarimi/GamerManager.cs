using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager
    {
        public void Add(int Id, string Tckn, string FirstName, string LastName, string DogumTarihi)
        {
            Gamer gamer = new Gamer();
            gamer.Id = Id;
            gamer.FirstName = FirstName;
            gamer.LastName = LastName;
            gamer.Tckn = Tckn;
            gamer.DogumTarihi = DogumTarihi;


            Console.WriteLine(gamer.Id + " Id li " + FirstName + " " + LastName + " isimli oyuncu sisteme eklenmiştir.");
        }

        public void Update(int Id, string Tckn, string FirstName, string LastName, string DogumTarihi)
        {
            Gamer gamer = new Gamer();
            gamer.Id = Id;
            gamer.FirstName = FirstName;
            gamer.LastName = LastName;
            gamer.Tckn = Tckn;
            gamer.DogumTarihi = DogumTarihi;


            Console.WriteLine(gamer.Id + " Id li " + FirstName + " " + LastName + " isimli oyuncu bilgileri güncellenmiştir.");
        }

        public void Delete(int Id)
        {
            Gamer gamer = new Gamer();
            gamer.Id = Id;
            Console.WriteLine(gamer.Id + " Id li oyuncu silindi");
        }

        public void CheckGamerInfoFromEDevlet(int Id, string Tckn, string FirstName, string LastName, string DogumTarihi)
        {
            Gamer gamer = new Gamer();
            gamer.Id = Id;
            gamer.FirstName = FirstName;
            gamer.LastName = LastName;
            gamer.Tckn = Tckn;
            gamer.DogumTarihi = DogumTarihi;
            Console.WriteLine(gamer.Id + " Id li " + FirstName + " " + LastName + " isimli oyuncu için doğrulama yapılmıştır.");
        }
    }
}
