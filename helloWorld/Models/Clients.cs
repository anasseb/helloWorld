using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace helloWorld.Models
{
    public class Clients
    {
        public List<Client> ObtenirListeClients()
        {
            return new List<Client>
            {
                new Client {Age = 20, Nom = "Anass" },
                new Client {Age = 20, Nom = "Karima" },
                new Client {Age = 20, Nom = "Yacout" },
                new Client {Age = 20, Nom = "Israa" },
            };
        }
    }
}