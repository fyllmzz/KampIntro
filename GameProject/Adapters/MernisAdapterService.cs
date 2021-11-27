using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
//using MernisServiceReference;

namespace Game_Backend
{
    class MernisAdapterService : IGamerCheck
    {
        //public bool Check(Gamer gamer)
        //{
        //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        //return client.TCKimlikNoDogrulaAsync(
        //    Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateofBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        // }
        public bool Check(Gamer gamer)
        {
            Console.WriteLine("dsfs");
        }
    }
}