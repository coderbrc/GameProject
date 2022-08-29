using GameProject.Abstract;
using GameProject.Entities;
using GameProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckifRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient();
            return kPSPublicSoapClient.TCKimlikNoDogrula(Convert.ToInt64(gamer.TCKN),gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.DateofBird.Year);
        }
    }
}
