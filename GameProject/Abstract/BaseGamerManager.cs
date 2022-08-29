using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Kişi eklendi."+gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kişi silindi..." + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kişi güncellendi." + gamer.FirstName);
        }
    }
}
