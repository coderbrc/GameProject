using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Sale(Gamer gamers, Game games);
        void SalewithCampaign(Gamer gamers,Game games, Campaign campaign);
    }
}
