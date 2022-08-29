using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                DateofBird = new DateTime(1992, 09, 18),
                FirstName = "Burçak",
                LastName = "Kasap",
                TCKN = "11111111111"
            };
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);
            GameManager gameManager = new GameManager();
            Game game1 = new Game
            {
                Id = 1,
                Name = "Candy Crush Saga",
                Price = 200
            };
            CampaignManager campaingManager = new CampaignManager();
            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "  %20 İNDİRİMLİ ",
                Discount = 0.20M
            };
            campaingManager.Add(campaign1);
            SaleManager saleManager = new SaleManager();
            saleManager.SalewithCampaign(gamer1, game1, campaign1);
            Console.ReadLine();
        }
    }
}
