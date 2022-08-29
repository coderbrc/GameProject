using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void SalewithCampaign(Gamer gamers, Game games, Campaign campaign)
        {
            Console.WriteLine(games.Name+" adlı oyunlar " + gamers.FirstName + " adlı oyuncu tarafından"
                + campaign.Name + " adlı kampanya ile sipariş verildi.");
        }

        public void Sale(Gamer gamers, Game games)
        {
            Console.WriteLine(games.Name+" adlı oyunlar " + gamers.FirstName + " adlı oyuncu tarafından sipariş verildi.");
        }
    }
}
