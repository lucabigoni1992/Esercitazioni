using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classivirtuali_astratte_ereditarieta.DM
{
    internal abstract class ScontiBase
    {
        public abstract float CalcolaSconto(float prezzo);
        public abstract float CalcolaScontoProdotto(Prodotto prodotto);
        public abstract float CalcolaScontoProdotti(List<Prodotto> prodotti);
    }
}
