using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using MernisServiceReference;


namespace DataAccess.Adapters
{
    public class MernisServiceAdapter 
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = client.TCKimlikNoDogrulaAsync(
                Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName, gamer.LastName, gamer.BirthYear);

            return response.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
