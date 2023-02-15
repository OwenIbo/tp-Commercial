using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Commercial
{
    internal class Service
    {
        private string nomService;
        private Commercial[] commerciaux;
        private int effectif;

        public Service(string nomService)
        {
            this.nomService = nomService;
            this.commerciaux = new Commercial[10];
            this.effectif = 0;
        }

        public string NomService
        {
            get { return nomService; }
            set { nomService = value; }
        }

        public int Effectif
        {
            get { return effectif; }
        }

        public void AjouterCom(Commercial c)
        {
            if (effectif < commerciaux.Length)
            {
                commerciaux[effectif] = c;
                effectif++;
            }
        }

        public void AfficherCommerciaux()
        {
            Console.WriteLine($"Commerciaux du service {nomService}:");
            for (int i = 0; i < effectif; i++)
            {
                Console.WriteLine(commerciaux[i].ToString());
            }
        }
    }

}
