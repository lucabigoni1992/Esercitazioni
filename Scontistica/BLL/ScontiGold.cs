using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Classivirtuali_astratte_ereditarieta.DM;

namespace Classivirtuali_astratte_ereditarieta.BLL
{
    internal class ScontiGold : ScontiBase
    {
        private float sconto = 0.05f;
        public override float CalcolaSconto(float prezzo)
        {
            prezzo *= sconto;
            return prezzo;
        }

        public override float CalcolaScontoProdotti(List<Prodotto> prodotti)
        {
            float prezzo = 0;
            foreach (var prodotto in prodotti)
            {
                prezzo += prodotto.Prezzo * prodotto.Quantita;
            }
            return prezzo * sconto;
        }
        public override float CalcolaScontoProdotto(Prodotto prodotto)
        {
            return prodotto.Prezzo * prodotto.Quantita * sconto;
        }
    }
}
